using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace AllTheWordsOfTheWorld
{
    public partial class frmMain : Form
    {
        bool isModified = false;
        int testDisplayIndex = -1;
        String[] testDisplayArray;
        String subKey = @"software\LFCConsulting\atwoth", keyValue = "Last Saved", lastSaved = "";
        SortedList<String, WordStore> lexicon = new SortedList<string, WordStore>();

        public frmMain()
        {
            InitializeComponent();
            splitMain.SplitterDistance = 250;
            pnlEdit.Dock = DockStyle.Fill;
            pnlRevise.Dock = DockStyle.Fill;
            pnlRevise.Visible = false;
            getLastSaved();
            if (lastSaved.Length > 0) actualLoad(null, null, lastSaved);
            dgvMain_SizeChanged(null, null);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Object regVal;
            RegistryKey baseKey;

            if ( lastSaved.Length > 0 )
            {
                baseKey = Registry.CurrentUser.OpenSubKey(subKey, true);
                if (baseKey == null) baseKey = Registry.CurrentUser.CreateSubKey(subKey, true);
                baseKey.SetValue(keyValue, lastSaved, RegistryValueKind.String);
                baseKey.Close();
            }
        }

        private void getLastSaved()
        {
            Object regVal;
            RegistryKey baseKey;

            baseKey = Registry.CurrentUser.OpenSubKey(subKey, false);
            if (baseKey == null) return;
            regVal = baseKey.GetValue(keyValue);
            if (regVal != null) lastSaved = regVal.ToString();
            baseKey.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvMain_SizeChanged(object sender, EventArgs e)
        {
            int panelWidth, gridWidth, finalColWidth;

            panelWidth = dgvMain.Width;
            gridWidth = dgvMain.Columns[0].Width + dgvMain.Columns[1].Width + dgvMain.Columns[2].Width;
            finalColWidth = panelWidth - gridWidth;
            if (finalColWidth > 200) dgvMain.Columns[3].Width = finalColWidth;
            else dgvMain.Columns[3].Width = 200;
        }

        private void pnlInfo_Resize(object sender, EventArgs e)
        {
            pnlInfo.Width = 514;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if( String.Compare( btnTest.Text, "Test" ) == 0 )
            {
                pnlEdit.Visible = false;
                pnlRevise.Visible = true;
                btnTest.Text = "Edit";
                if( isModified ) btnStore_Click(sender, e);
                btnClear_Click(sender, e);
                testDisplayIndex = -1;
                btnNext.Text = "Start";
            }
            else
            {
                pnlEdit.Visible = true;
                pnlRevise.Visible = false;
                btnTest.Text = "Test";
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            /*************************************************************************************************
             *                                                                                               *
             *                             btnStore_Click: Store the current Entry                           *
             *                             =======================================                           *
             *                                                                                               *
             *  Adds the current entry to the store but does not remove it from presentation.                *
             *                                                                                               *
             *************************************************************************************************/
            bool isEditMode = false;
            int idx;
            String keyWord = "", keyPstn, sourceText, englishText, exampleText;
            DataGridViewCell cell1, cell2, cell3, cell4;
            WordStore currentWordStore = null;
            DialogResult dlgResult;

            for( idx = 0; idx < dgvMain.RowCount; idx++ )
            {
                cell1 = dgvMain.Rows[idx].Cells[0];
                cell2 = dgvMain.Rows[idx].Cells[1];
                cell3 = dgvMain.Rows[idx].Cells[2];
                cell4 = dgvMain.Rows[idx].Cells[3];
                if( (cell1.Value == null ) && ( cell2.Value == null ) && ( cell3.Value == null ) && ( cell4.Value == null ) ) continue;  // Nothing to save
                if (cell1.Value == null) keyPstn = "";
                else keyPstn = cell1.Value.ToString();
                if (cell2.Value == null) sourceText = "";
                else sourceText = cell2.Value.ToString();
                if (cell3.Value == null) englishText = "";
                else englishText = cell3.Value.ToString();
                if (cell4.Value == null) exampleText = "";
                else exampleText = cell4.Value.ToString();
                if (idx == 0)
                {
                    if (keyPstn.Length == 0)
                    {
                        MessageBox.Show("You must provide a keyword for the entry", "Keyword error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    keyWord = keyPstn;
                    if (lexicon.ContainsKey(keyWord))
                    {
                        dlgResult = MessageBox.Show("Replace any changed values (Yes) or abort (No)", "The keyword " + keyWord + " has already been used",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dlgResult == DialogResult.Yes) isEditMode = true;
                        else return;
                    }
                    if (isEditMode) lexicon.TryGetValue(keyWord, out currentWordStore);
                    else
                    {
                        currentWordStore = new WordStore();
                        lexicon.Add(keyWord, currentWordStore);
                        currentWordStore.Keyword = keyWord;
                    }
                }
                    currentWordStore.addEntry(sourceText, englishText, exampleText);
            }
            if (!isEditMode) cbEntries.Items.Add(keyWord);
            isModified = true;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            /*************************************************************************************************
             *                                                                                               *
             *                 btnClearAll_Click: Clear Store Completely (i.e. erase all data)               *
             *                 ===============================================================               *
             *                                                                                               *
             *  Clear all contents from WordStore (and clear the display).                                   *
             *                                                                                               *
             *************************************************************************************************/
            int noOfGridEntries;
            WordStore currentStore;

            btnClear_Click(sender, e);
            foreach( KeyValuePair<String, WordStore> wordStorePair in lexicon)
            {
                currentStore = wordStorePair.Value;
                noOfGridEntries = currentStore.NoOfEntries;
                currentStore.disposeAllGridEntries();
            }
            lexicon.Clear();
            cbEntries.Items.Clear();
            cbEntries.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /*************************************************************************************************
             *                                                                                               *
             *                  btnClear_Click: Clear the current Entry (without storing it)                 *
             *                  ============================================================                 *
             *                                                                                               *
             *  Returns state to starting point.                                                             *
             *                                                                                               *
             *************************************************************************************************/

            dgvMain.Rows.Clear();
            dgvMain.RowCount = 1;
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            /*************************************************************************************************
             *                                                                                               *
             *                                btnNewEntry_Click: Start a New Entry                           *
             *                                ====================================                           *
             *                                                                                               *
             *  Uses btnStore_Click to store the data, then btnClear_Click to return state to starting       *
             *    point.                                                                                     *
             *                                                                                               *
             *************************************************************************************************/
            EditEntry entryForm;

            btnStore_Click(sender, e);
            btnClear_Click(sender, e);
            entryForm = new EditEntry("", "", "", "", true, true);
            if ( entryForm.ShowDialog() == DialogResult.OK )
            {
                dgvMain.RowCount++;
                dgvMain.Rows[0].Cells[0].Value = entryForm.KeyWord;
                dgvMain.Rows[0].Cells[1].Value = entryForm.SourceEntry;
                dgvMain.Rows[0].Cells[2].Value = entryForm.EnglishEntry;
                dgvMain.Rows[0].Cells[3].Value = entryForm.ExampleEntry;
            }
            entryForm.Dispose();
        }

        private void btnAddToEntry_Click(object sender, EventArgs e)
        {
            /*************************************************************************************************
             *                                                                                               *
             *                    btnAddToEntry_Click: Add a Word or Expression to the Entry                 *
             *                    ==========================================================                 *
             *                                                                                               *
             *  Add a single row of data (excluding the keyword).  The entry will be added to the end of the *
             *    data in the grid.                                                                          *
             *                                                                                               *
             *************************************************************************************************/
            int currRow = 0;
            EditEntry entryForm;

            entryForm = new EditEntry(dgvMain.Rows[0].Cells[0].Value.ToString(), "", "", "", true, false);
            if (entryForm.ShowDialog() == DialogResult.OK)
            {
                currRow = dgvMain.RowCount - 1;
                if (currRow == 0) return;
                dgvMain.RowCount++;
                dgvMain.Rows[currRow].Cells[0].Value = "";
                dgvMain.Rows[currRow].Cells[1].Value = entryForm.SourceEntry;
                dgvMain.Rows[currRow].Cells[2].Value = entryForm.EnglishEntry;
                dgvMain.Rows[currRow].Cells[3].Value = entryForm.ExampleEntry;
            }
            entryForm.Dispose();
        }

        private void actualSave( String fullFileName)
        {
            int idx, noOfEntries;
            ulong recordCount;
            Char[] charArray;
            String itemSeperator = "\u2063", recordContent, keyWord;
            StreamWriter swSave;
            WordStore currentEntry;
            GridEntry specificGridEntry;
            DataGridViewCell tempCell;

            // Check whether the current grid entry has been saved
            tempCell = dgvMain.Rows[0].Cells[0];
            if( tempCell.Value != null )
            {
                keyWord = tempCell.Value.ToString();
                if( keyWord.Length > 0 )
                {
                    if( ! lexicon.ContainsKey( keyWord ) )
                    {
                        btnStore_Click(dgvMain, null);
                    }
                }
            }
            // Now save all stored items
            swSave = new StreamWriter(fullFileName);
            foreach (KeyValuePair<String, WordStore> singleEntry in lexicon)
            {
                currentEntry = singleEntry.Value;
                noOfEntries = currentEntry.NoOfEntries;
                swSave.Write( currentEntry.Keyword + itemSeperator + noOfEntries.ToString() + itemSeperator);
                recordContent = "";
                for (idx = 0; idx < noOfEntries; idx++)
                {
                    specificGridEntry = currentEntry.getGridEntryByIndex(idx);
                    recordContent += specificGridEntry.ExpressionOrWord + itemSeperator;
                    recordContent += specificGridEntry.EnglishText + itemSeperator;
                    recordContent += specificGridEntry.ExampleText + itemSeperator;
                }
                recordCount = (ulong)recordContent.Length;
                swSave.WriteLine(recordCount);
                charArray = recordContent.ToCharArray();
                swSave.Write(charArray);
            }
            swSave.Close();
            swSave.Dispose();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            int nPstn;
            String initialDirectory;

            if (lastSaved.Length > 0)
            {
                nPstn = lastSaved.LastIndexOf('\\');
                initialDirectory = lastSaved.Substring(0, nPstn);
                dlgSave.InitialDirectory = initialDirectory;
                dlgSave.FileName = lastSaved;
            }
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                actualSave(dlgSave.FileName);
                isModified = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isModified) return;
            if (lastSaved.Length == 0) btnSaveAs_Click(sender, e);
            else
            {
                actualSave(lastSaved);
                isModified = false;
            }
        }

        private void actualLoad(object sender, EventArgs e, String fullFileName)
        {
            int recNo, idx, noOfLines;
            ulong recordCount;
            Char[] charArray;
            String keyWord, fileBuffer;
            String[] recordFields;
            Char[] splitParams = { '\u2063' };
            StreamReader srOpen;
            WordStore currentEntry;

                btnClearAll_Click(sender, e);
                // Load the data and store in the classes
                srOpen = new StreamReader(fullFileName);
                fileBuffer = srOpen.ReadLine();
                while (fileBuffer != null)
                {
                    recordFields = fileBuffer.Split(splitParams);
                    keyWord = recordFields[0];
                    noOfLines = Convert.ToInt32(recordFields[1]);
                    recordCount = Convert.ToUInt64(recordFields[2]);
                    charArray = new Char[recordCount];
                    srOpen.ReadBlock(charArray, 0, (int)recordCount);
                    fileBuffer = new String(charArray);
                    recordFields = fileBuffer.Split(splitParams);
                    currentEntry = new WordStore();
                    currentEntry.Keyword = keyWord;
                    recNo = 0;
                    for (idx = 0; idx < noOfLines; idx++)
                    {
                        currentEntry.addEntry(recordFields[recNo++], recordFields[recNo++], recordFields[recNo++]);
                    }
                    lexicon.Add(keyWord, currentEntry);
                    cbEntries.Items.Add(keyWord);
                    fileBuffer = srOpen.ReadLine();
                }
                srOpen.Close();
                srOpen.Dispose();
                cbEntries.SelectedIndex = 0;
                btnDisplay_Click(sender, e);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int nPstn;
            String initialDirectory;
            DialogResult givenResponse;

            if (isModified)
            {
                givenResponse = MessageBox.Show("You have unsaved additions that you will lose if you go ahead with this action",
                    "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else givenResponse = DialogResult.Yes;
            if (givenResponse == DialogResult.Yes)
            {
                if (lastSaved.Length > 0)
                {
                    nPstn = lastSaved.LastIndexOf('\\');
                    initialDirectory = lastSaved.Substring(0, nPstn);
                    dlgOpen.InitialDirectory = initialDirectory;
                    dlgOpen.FileName = lastSaved;
                }
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    actualLoad(sender, e, dlgOpen.FileName);
                    lastSaved = dlgOpen.FileName;
                }
            }
            isModified = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            /*************************************************************************************************
             *                                                                                               *
             *                       btnDisplay_Click: Display currently Selected Entry                      *
             *                       ==================================================                      *
             *                                                                                               *
             *  Apply the currently selected keyWord from Store to the display.                              *
             *                                                                                               *
             *************************************************************************************************/
            int idx, noOfEntries;
            String keyWord;
            WordStore currStore;
            GridEntry currGridItem;

            if( cbEntries.SelectedIndex > -1 )
            {
                keyWord = cbEntries.SelectedItem.ToString();
                if( lexicon.ContainsKey( keyWord ) )
                {
                    btnClear_Click(sender, e);
                    lexicon.TryGetValue(keyWord, out currStore);
                    noOfEntries = currStore.NoOfEntries;
                    for( idx = 0; idx < noOfEntries; idx++ )
                    {
                        currGridItem = currStore.getGridEntryByIndex(idx);
                        dgvMain.RowCount++;
                        if (idx == 0) dgvMain.Rows[idx].Cells[0].Value = keyWord;
                        dgvMain.Rows[idx].Cells[1].Value = currGridItem.ExpressionOrWord;
                        dgvMain.Rows[idx].Cells[2].Value = currGridItem.EnglishText;
                        dgvMain.Rows[idx].Cells[3].Value = currGridItem.ExampleText;
                    }
                }
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            /*************************************************************************************************
             *                                                                                               *
             *                  btnErase_Click: Erase the currently Selected Entry from Store                *
             *                  =============================================================                *
             *                                                                                               *
             *************************************************************************************************/
            int selIdx;
            String keyWord;
            WordStore currStore;

            if (cbEntries.SelectedIndex > -1)
            {
                selIdx = cbEntries.SelectedIndex;
                keyWord = cbEntries.SelectedItem.ToString();
                if (lexicon.ContainsKey(keyWord))
                {
                    lexicon.TryGetValue(keyWord, out currStore);
                    currStore.disposeAllGridEntries();
                    lexicon.RemoveAt(lexicon.IndexOfKey(keyWord));
                    if( dgvMain.Rows[0].Cells[0].Value != null)
                    {
                        if( String.Compare(dgvMain.Rows[0].Cells[0].Value.ToString(), keyWord) == 0 )
                        {
                            dgvMain.Rows.Clear();
                            dgvMain.RowCount = 1;
                        }
                    }
                    cbEntries.Items.RemoveAt(selIdx);
                    if (cbEntries.Items.Count > selIdx) cbEntries.SelectedIndex = selIdx;
                    else
                    {
                        if (cbEntries.Items.Count > 0) cbEntries.SelectedIndex = cbEntries.Items.Count - 1;
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int noOfEntries;

            int idx, jdx, noOfItems, itemIndex, simpleCount = 0;
            SortedList<int, String> tempStore = new SortedList<int, string>();
            String keyWord, tempWord;
            WordStore currStore;
            GridEntry currGridItem;
            Random randomNo;

            noOfItems = cbEntries.Items.Count;
            if (noOfItems == 0) return;
            if (testDisplayIndex == -1)
            {
                testDisplayArray = new String[noOfItems];
                for (idx = 0; idx < noOfItems; idx++) tempStore.Add(idx, cbEntries.Items[idx].ToString());
                if (rbRandom.Checked)
                {
                    while (noOfItems > 1)
                    {
                        randomNo = new Random();
                        itemIndex = randomNo.Next(0, noOfItems);
//                        tempStore.TryGetValue(itemIndex, out testDisplayArray[simpleCount++]);
                        testDisplayArray[simpleCount++] = tempStore.ElementAt(itemIndex).Value;
                        tempStore.RemoveAt(itemIndex);
/*                        for( jdx = itemIndex + 1; jdx < noOfItems; jdx++ )
                        {
                            tempStore.TryGetValue(jdx, out tempWord);
                            tempStore.Rem  .RemoveAt(jdx);
                            tempStore.Add(jdx - 1, tempWord);
                        } */
                        noOfItems--;
                    }
                    testDisplayArray[simpleCount++] = tempStore.ElementAt(0).Value;
                }
                else
                {
                    for (idx = 0; idx < noOfItems; idx++) testDisplayArray[simpleCount++] = tempStore[idx];
                }
            }
            if (++testDisplayIndex == testDisplayArray.Length) return;
            keyWord = testDisplayArray[testDisplayIndex];
            if (lexicon.ContainsKey(keyWord))
            {
                btnClear_Click(sender, e);
                lexicon.TryGetValue(keyWord, out currStore);
                noOfEntries = currStore.NoOfEntries;
                for (idx = 0; idx < noOfEntries; idx++)
                {
                    currGridItem = currStore.getGridEntryByIndex(idx);
                    dgvMain.RowCount++;
                    if ((idx == 0) && (cbKeyword.Checked)) dgvMain.Rows[idx].Cells[0].Value = keyWord;
                    if (cbNonEnglish.Checked) dgvMain.Rows[idx].Cells[1].Value = currGridItem.ExpressionOrWord;
                    if (cbEnglish.Checked) dgvMain.Rows[idx].Cells[2].Value = currGridItem.EnglishText;
                    if (cbExample.Checked) dgvMain.Rows[idx].Cells[3].Value = currGridItem.ExampleText;
                }
            }
            btnNext.Text = "Next";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*************************************************************************************************
             *                                                                                               *
             *                         btnEdit_Click: Modify the currently Selected row                      *
             *                         ================================================                      *
             *                                                                                               *
             *************************************************************************************************/
            int idx, currRow = 0;
            String keyWordText, sourceText, engText, egText;
            EditEntry entryForm;
            DataGridViewCell dataGridViewCell;

            dataGridViewCell = dgvMain.Rows[0].Cells[0];
            if (dataGridViewCell.Value == null) return;
            keyWordText = dataGridViewCell.Value.ToString();
            if (keyWordText.Length == 0) return;
            for( idx = 0; idx < dgvMain.RowCount; idx++ )
            {
                if( dgvMain.Rows[idx].Selected )
                {
                    currRow = idx;
                    break;
                }
            }
            dataGridViewCell = dgvMain.Rows[currRow].Cells[1];
            if (dataGridViewCell.Value == null) sourceText = "";
            else sourceText = dataGridViewCell.Value.ToString();
            dataGridViewCell = dgvMain.Rows[currRow].Cells[2];
            if (dataGridViewCell.Value == null) engText = "";
            else engText = dataGridViewCell.Value.ToString();
            dataGridViewCell = dgvMain.Rows[currRow].Cells[3];
            if (dataGridViewCell.Value == null) egText = "";
            else egText = dataGridViewCell.Value.ToString();
            entryForm = new EditEntry(keyWordText, sourceText, engText, egText, false, false);
            if (entryForm.ShowDialog() == DialogResult.OK)
            {
                dgvMain.Rows[currRow].Cells[1].Value = entryForm.SourceEntry;
                dgvMain.Rows[currRow].Cells[2].Value = entryForm.EnglishEntry;
                dgvMain.Rows[currRow].Cells[3].Value = entryForm.ExampleEntry;
            }
            entryForm.Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            /*************************************************************************************************
             *                                                                                               *
             *                        btnRemove_Click: Remove the currently Selected row                     *
             *                        ==================================================                     *
             *                                                                                               *
             *  Remove the currently selected row and adjust settings so that the grid has the correct       *
             *    number of rows.                                                                            *
             *                                                                                               *
             *************************************************************************************************/
            int idx, currRow = 0;
            String keyWordText, sourceText, engText, egText;
            EditEntry entryForm;
            DataGridViewCell dataGridViewCell;

            for (idx = 0; idx < dgvMain.RowCount; idx++)
            {
                if (dgvMain.Rows[idx].Selected)
                {
                    currRow = idx;
                    break;
                }
            }
            if( currRow == 0 )
            {
                if( dgvMain.RowCount == 2 )
                {
                    MessageBox.Show("If you want to remove all rows, you must select the button: \n\"Clear the Current Emtry\" or \"Start a New Entry\"",
                        "Unable to remove all rows", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                dataGridViewCell = dgvMain.Rows[0].Cells[0];
                if (dataGridViewCell.Value == null) return;
                keyWordText = dataGridViewCell.Value.ToString();
                if (keyWordText.Length == 0) return;
                dgvMain.Rows[1].Cells[0].Value = keyWordText;
            }
            dgvMain.Rows.RemoveAt(currRow);
        }
    }
}
