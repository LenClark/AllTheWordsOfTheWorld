using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllTheWordsOfTheWorld
{
    public partial class EditEntry : Form
    {
        bool isNew, isFirst;
        String keyWord, sourceEntry, englishEntry, exampleEntry;
        Button[] buttonStore;
        TextBox currentBox;

        public EditEntry(String keyWordIn, String sourceIn, String engIn, String egIn, bool isNewItem, bool isFirstItem )
        {
            InitializeComponent();
            keyWord = keyWordIn;
            sourceEntry = sourceIn;
            englishEntry = engIn;
            exampleEntry = egIn;
            txtKeyword.Text = keyWord;
            isNew = isNewItem;
            isFirst = isFirstItem;
            if (isNew)
            {
                if (isFirst) this.Text = "Creating entries for a new keyword";
                else
                {
                    txtKeyword.ReadOnly = true;
                    this.Text = "Creating an additional entry for the keyword: " + keyWord;
                }
            }
            else
            {
                txtKeyword.ReadOnly = true;
                this.Text = "Modifying an entry for the keyword: " + keyWord;
            }
            txtSource.Text = sourceEntry;
            txtEnglish.Text = englishEntry;
            txtExemple.Text = exampleEntry;
            displayKeys();
        }

        public string KeyWord { get => keyWord; set => keyWord = value; }
        public string SourceEntry { get => sourceEntry; set => sourceEntry = value; }
        public string EnglishEntry { get => englishEntry; set => englishEntry = value; }
        public string ExampleEntry { get => exampleEntry; set => exampleEntry = value; }

        private void displayKeys()
        {
            int idx, subIdx, totalLetters = 0, keyTop = 4, keyLeft = 4, keyGap = 4, keyWidth = 32, keyHeight = 32;
            int[] letterBounds = { 12, 10, 8, 8, 2, 12, 11, 4 };
            String[] oddLetters = { "À", "Á", "Â", "Ã", "Ä", "Å", "à", "á", "â", "ã", "ä", "å", "Ç", "Ć", "Ĉ", "Ċ", "Č", "ç", "ć", "ĉ", "ċ", "č",
                                 "È", "É", "Ê", "Ë", "è", "é", "ê", "ë", "Ì", "Í", "Î", "Ï", "ì", "í", "î", "ï", "Ñ", "ñ",
                                 "Ò", "Ó", "Ô", "Õ", "Ö", "Ø", "ò", "ó", "ô", "õ", "ö", "ø", "Ù", "Ú", "Û", "Ü", "Ý", "ù", "ú", "û", "ü", "ý", "ÿ",
                                 "Æ", "æ", "Œ", "œ" };
            Font largeFont = new Font("Arial", 16);
            Button tempButton;

            for (idx = 0; idx < letterBounds.Length; idx++) totalLetters += letterBounds[idx];
            buttonStore = new Button[totalLetters];
            totalLetters = 0;
            for (subIdx = 0; subIdx < letterBounds.Length; subIdx++)
            {
                for (idx = 0; idx < letterBounds[subIdx]; idx++)
                {
                    tempButton = new Button();
                    tempButton.Top = keyTop + (keyHeight + keyGap) * subIdx;
                    tempButton.Left = keyLeft + (keyWidth + keyGap) * idx;
                    tempButton.Height = keyHeight;
                    tempButton.Width = keyWidth;
                    tempButton.Text = oddLetters[totalLetters];
                    tempButton.Font = largeFont;
                    tempButton.Tag = totalLetters;
                    tempButton.Click += TempButton_Click;
                    pnlKeys.Controls.Add(tempButton);
                    buttonStore[totalLetters] = tempButton;
                    totalLetters++;
                }
            }
        }

        private void TempButton_Click(object sender, EventArgs e)
        {
            int caretPstn, textboxLength;
            String leftPart, rightPart;
            Button clickedButton;

            clickedButton = (Button)sender;
            textboxLength = currentBox.Text.Length;
            if (textboxLength == 0)
            {
                currentBox.Text = clickedButton.Text;
                currentBox.SelectionStart = 1;
                currentBox.Focus();
                return;
            }
            caretPstn = currentBox.SelectionStart;
            if (caretPstn == 0)
            {
                currentBox.Text = clickedButton.Text + currentBox.Text;
                currentBox.SelectionStart = caretPstn + 1;
                currentBox.Focus();
                return;
            }
            if (caretPstn == textboxLength)
            {
                currentBox.Text += clickedButton.Text;
                currentBox.SelectionStart = caretPstn + 1;
                currentBox.Focus();
                return;
            }
            leftPart = currentBox.Text.Substring(0, caretPstn);
            rightPart = currentBox.Text.Substring(caretPstn);
            currentBox.Text = leftPart + clickedButton.Text + rightPart;
            currentBox.SelectionStart = caretPstn + 1;
            currentBox.Focus();
        }

        private void textboxEntry(object sender, EventArgs e)
        {
            currentBox = (TextBox)sender;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isNew) keyWord = txtKeyword.Text;
            sourceEntry = txtSource.Text;
            englishEntry = txtEnglish.Text;
            exampleEntry = txtExemple.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
