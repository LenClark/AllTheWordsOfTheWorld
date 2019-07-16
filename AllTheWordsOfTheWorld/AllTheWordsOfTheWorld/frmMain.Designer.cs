namespace AllTheWordsOfTheWorld
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.pnlRevise = new System.Windows.Forms.Panel();
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.gbCriteria = new System.Windows.Forms.GroupBox();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbInOrder = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbExample = new System.Windows.Forms.CheckBox();
            this.cbEnglish = new System.Windows.Forms.CheckBox();
            this.cbNonEnglish = new System.Windows.Forms.CheckBox();
            this.cbKeyword = new System.Windows.Forms.CheckBox();
            this.labShowLbl = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.gbStoreManagement = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.labCurrentStore = new System.Windows.Forms.Label();
            this.cbEntries = new System.Windows.Forms.ComboBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.gbEntry = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddToEntry = new System.Windows.Forms.Button();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.txtInfoHeader = new System.Windows.Forms.TextBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlRevise.SuspendLayout();
            this.gbTest.SuspendLayout();
            this.gbCriteria.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.gbStoreManagement.SuspendLayout();
            this.gbEntry.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.btnSaveAs);
            this.pnlBase.Controls.Add(this.btnLoad);
            this.pnlBase.Controls.Add(this.btnSave);
            this.pnlBase.Controls.Add(this.btnTest);
            this.pnlBase.Controls.Add(this.btnClose);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBase.Location = new System.Drawing.Point(0, 585);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(988, 28);
            this.pnlBase.TabIndex = 0;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(404, 3);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(123, 23);
            this.btnSaveAs.TabIndex = 15;
            this.btnSaveAs.Text = "Save All to &File As ...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(146, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(123, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "&Load from File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(275, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save &All to File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(901, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.pnlRevise);
            this.splitMain.Panel1.Controls.Add(this.pnlEdit);
            this.splitMain.Panel1.Controls.Add(this.pnlInfo);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.dgvMain);
            this.splitMain.Size = new System.Drawing.Size(988, 585);
            this.splitMain.SplitterDistance = 403;
            this.splitMain.TabIndex = 1;
            // 
            // pnlRevise
            // 
            this.pnlRevise.Controls.Add(this.gbTest);
            this.pnlRevise.Location = new System.Drawing.Point(18, 266);
            this.pnlRevise.Name = "pnlRevise";
            this.pnlRevise.Size = new System.Drawing.Size(450, 134);
            this.pnlRevise.TabIndex = 4;
            // 
            // gbTest
            // 
            this.gbTest.Controls.Add(this.gbCriteria);
            this.gbTest.Controls.Add(this.btnNext);
            this.gbTest.Controls.Add(this.cbExample);
            this.gbTest.Controls.Add(this.cbEnglish);
            this.gbTest.Controls.Add(this.cbNonEnglish);
            this.gbTest.Controls.Add(this.cbKeyword);
            this.gbTest.Controls.Add(this.labShowLbl);
            this.gbTest.Location = new System.Drawing.Point(16, 14);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(428, 117);
            this.gbTest.TabIndex = 0;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "Test your knowledge: ";
            // 
            // gbCriteria
            // 
            this.gbCriteria.Controls.Add(this.rbRandom);
            this.gbCriteria.Controls.Add(this.rbInOrder);
            this.gbCriteria.Location = new System.Drawing.Point(186, 17);
            this.gbCriteria.Name = "gbCriteria";
            this.gbCriteria.Size = new System.Drawing.Size(114, 70);
            this.gbCriteria.TabIndex = 7;
            this.gbCriteria.TabStop = false;
            this.gbCriteria.Text = "Criteria: ";
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(18, 43);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(72, 17);
            this.rbRandom.TabIndex = 6;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Randomly";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // rbInOrder
            // 
            this.rbInOrder.AutoSize = true;
            this.rbInOrder.Checked = true;
            this.rbInOrder.Location = new System.Drawing.Point(18, 20);
            this.rbInOrder.Name = "rbInOrder";
            this.rbInOrder.Size = new System.Drawing.Size(90, 17);
            this.rbInOrder.TabIndex = 5;
            this.rbInOrder.TabStop = true;
            this.rbInOrder.Text = "Alphabetically";
            this.rbInOrder.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(324, 20);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Start";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbExample
            // 
            this.cbExample.AutoSize = true;
            this.cbExample.Location = new System.Drawing.Point(57, 86);
            this.cbExample.Name = "cbExample";
            this.cbExample.Size = new System.Drawing.Size(90, 17);
            this.cbExample.TabIndex = 4;
            this.cbExample.Text = "Example Text";
            this.cbExample.UseVisualStyleBackColor = true;
            // 
            // cbEnglish
            // 
            this.cbEnglish.AutoSize = true;
            this.cbEnglish.Location = new System.Drawing.Point(57, 64);
            this.cbEnglish.Name = "cbEnglish";
            this.cbEnglish.Size = new System.Drawing.Size(60, 17);
            this.cbEnglish.TabIndex = 3;
            this.cbEnglish.Text = "English";
            this.cbEnglish.UseVisualStyleBackColor = true;
            // 
            // cbNonEnglish
            // 
            this.cbNonEnglish.AutoSize = true;
            this.cbNonEnglish.Location = new System.Drawing.Point(57, 42);
            this.cbNonEnglish.Name = "cbNonEnglish";
            this.cbNonEnglish.Size = new System.Drawing.Size(123, 17);
            this.cbNonEnglish.TabIndex = 2;
            this.cbNonEnglish.Text = "Non-English Word(s)";
            this.cbNonEnglish.UseVisualStyleBackColor = true;
            // 
            // cbKeyword
            // 
            this.cbKeyword.AutoSize = true;
            this.cbKeyword.Location = new System.Drawing.Point(57, 20);
            this.cbKeyword.Name = "cbKeyword";
            this.cbKeyword.Size = new System.Drawing.Size(67, 17);
            this.cbKeyword.TabIndex = 1;
            this.cbKeyword.Text = "Keyword";
            this.cbKeyword.UseVisualStyleBackColor = true;
            // 
            // labShowLbl
            // 
            this.labShowLbl.AutoSize = true;
            this.labShowLbl.Location = new System.Drawing.Point(19, 20);
            this.labShowLbl.Name = "labShowLbl";
            this.labShowLbl.Size = new System.Drawing.Size(37, 13);
            this.labShowLbl.TabIndex = 0;
            this.labShowLbl.Text = "Show:";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.gbStoreManagement);
            this.pnlEdit.Controls.Add(this.gbEntry);
            this.pnlEdit.Location = new System.Drawing.Point(12, 12);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(456, 248);
            this.pnlEdit.TabIndex = 3;
            // 
            // gbStoreManagement
            // 
            this.gbStoreManagement.Controls.Add(this.btnClearAll);
            this.gbStoreManagement.Controls.Add(this.btnErase);
            this.gbStoreManagement.Controls.Add(this.btnDisplay);
            this.gbStoreManagement.Controls.Add(this.labCurrentStore);
            this.gbStoreManagement.Controls.Add(this.cbEntries);
            this.gbStoreManagement.Controls.Add(this.btnStore);
            this.gbStoreManagement.Location = new System.Drawing.Point(6, 120);
            this.gbStoreManagement.Name = "gbStoreManagement";
            this.gbStoreManagement.Size = new System.Drawing.Size(444, 110);
            this.gbStoreManagement.TabIndex = 3;
            this.gbStoreManagement.TabStop = false;
            this.gbStoreManagement.Text = "Manage Stored Entries: ";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(16, 48);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(123, 38);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "Clear Store Completely (i.e. erase all data)";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(145, 55);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(123, 49);
            this.btnErase.TabIndex = 9;
            this.btnErase.Text = "&Erase the currently Selected Entry from Store";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(145, 11);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(123, 38);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "&Display currently Selected Entry";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // labCurrentStore
            // 
            this.labCurrentStore.AutoSize = true;
            this.labCurrentStore.Location = new System.Drawing.Point(274, 16);
            this.labCurrentStore.Name = "labCurrentStore";
            this.labCurrentStore.Size = new System.Drawing.Size(120, 13);
            this.labCurrentStore.TabIndex = 9;
            this.labCurrentStore.Text = "Currently Stored Entries:";
            // 
            // cbEntries
            // 
            this.cbEntries.FormattingEnabled = true;
            this.cbEntries.Location = new System.Drawing.Point(285, 36);
            this.cbEntries.Name = "cbEntries";
            this.cbEntries.Size = new System.Drawing.Size(150, 21);
            this.cbEntries.Sorted = true;
            this.cbEntries.TabIndex = 10;
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(16, 19);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(123, 23);
            this.btnStore.TabIndex = 5;
            this.btnStore.Text = "&Store the current Entry";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // gbEntry
            // 
            this.gbEntry.Controls.Add(this.btnEdit);
            this.gbEntry.Controls.Add(this.btnRemove);
            this.gbEntry.Controls.Add(this.btnClear);
            this.gbEntry.Controls.Add(this.btnAddToEntry);
            this.gbEntry.Controls.Add(this.btnNewEntry);
            this.gbEntry.Location = new System.Drawing.Point(6, 14);
            this.gbEntry.Name = "gbEntry";
            this.gbEntry.Size = new System.Drawing.Size(445, 100);
            this.gbEntry.TabIndex = 2;
            this.gbEntry.TabStop = false;
            this.gbEntry.Text = "Manage a Single group of Entries: ";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(161, 33);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 35);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Modify the currently Selected row";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(303, 14);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 35);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "&Remove the currently Selected row";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(303, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear the current Entry (without storing it)";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddToEntry
            // 
            this.btnAddToEntry.Location = new System.Drawing.Point(17, 49);
            this.btnAddToEntry.Name = "btnAddToEntry";
            this.btnAddToEntry.Size = new System.Drawing.Size(123, 35);
            this.btnAddToEntry.TabIndex = 1;
            this.btnAddToEntry.Text = "&Add a Word or Expression to the Entry";
            this.btnAddToEntry.UseVisualStyleBackColor = true;
            this.btnAddToEntry.Click += new System.EventHandler(this.btnAddToEntry_Click);
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.Location = new System.Drawing.Point(17, 20);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(123, 23);
            this.btnNewEntry.TabIndex = 0;
            this.btnNewEntry.Text = "&Start a New Entry";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.rtxtInfo);
            this.pnlInfo.Controls.Add(this.txtInfoHeader);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(474, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(514, 403);
            this.pnlInfo.TabIndex = 0;
            this.pnlInfo.Resize += new System.EventHandler(this.pnlInfo_Resize);
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInfo.Location = new System.Drawing.Point(0, 32);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.ReadOnly = true;
            this.rtxtInfo.Size = new System.Drawing.Size(514, 371);
            this.rtxtInfo.TabIndex = 1;
            this.rtxtInfo.Text = resources.GetString("rtxtInfo.Text");
            // 
            // txtInfoHeader
            // 
            this.txtInfoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInfoHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoHeader.ForeColor = System.Drawing.Color.Red;
            this.txtInfoHeader.Location = new System.Drawing.Point(0, 0);
            this.txtInfoHeader.Name = "txtInfoHeader";
            this.txtInfoHeader.ReadOnly = true;
            this.txtInfoHeader.Size = new System.Drawing.Size(514, 32);
            this.txtInfoHeader.TabIndex = 0;
            this.txtInfoHeader.Text = "Using \"All the Words of the World\"";
            this.txtInfoHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvMain
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(988, 178);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.SizeChanged += new System.EventHandler(this.dgvMain_SizeChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Keyword";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Word or Expression";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "English Translation";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Examples or comments";
            this.Column4.Name = "Column4";
            this.Column4.Width = 400;
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "vcb";
            this.dlgSave.Filter = "Vocab File|*.vcb|Text File|*.txt|All Files|*.*";
            this.dlgSave.Title = "Choose the location and name of your saved vocab information";
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "vcb";
            this.dlgOpen.Filter = "Vocab File|*.vcb|Text File|*.txt|All Files|*.*";
            this.dlgOpen.Title = "Load previous;y saved vocab into the application";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 613);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pnlBase);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All the Words of the World";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlBase.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pnlRevise.ResumeLayout(false);
            this.gbTest.ResumeLayout(false);
            this.gbTest.PerformLayout();
            this.gbCriteria.ResumeLayout(false);
            this.gbCriteria.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.gbStoreManagement.ResumeLayout(false);
            this.gbStoreManagement.PerformLayout();
            this.gbEntry.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.TextBox txtInfoHeader;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.GroupBox gbStoreManagement;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label labCurrentStore;
        private System.Windows.Forms.ComboBox cbEntries;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.GroupBox gbEntry;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddToEntry;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Panel pnlRevise;
        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.GroupBox gbCriteria;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbInOrder;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox cbExample;
        private System.Windows.Forms.CheckBox cbEnglish;
        private System.Windows.Forms.CheckBox cbNonEnglish;
        private System.Windows.Forms.CheckBox cbKeyword;
        private System.Windows.Forms.Label labShowLbl;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Button btnClearAll;
    }
}

