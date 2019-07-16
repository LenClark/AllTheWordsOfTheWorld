namespace AllTheWordsOfTheWorld
{
    partial class EditEntry
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
            this.pnlEntry = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlKeys = new System.Windows.Forms.Panel();
            this.txtExemple = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.labExample = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labSourceEntry = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.labKeyword = new System.Windows.Forms.Label();
            this.pnlEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEntry
            // 
            this.pnlEntry.Controls.Add(this.btnCancel);
            this.pnlEntry.Controls.Add(this.btnOK);
            this.pnlEntry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEntry.Location = new System.Drawing.Point(0, 419);
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Size = new System.Drawing.Size(584, 27);
            this.pnlEntry.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(497, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlKeys
            // 
            this.pnlKeys.Location = new System.Drawing.Point(43, 112);
            this.pnlKeys.Name = "pnlKeys";
            this.pnlKeys.Size = new System.Drawing.Size(487, 293);
            this.pnlKeys.TabIndex = 18;
            // 
            // txtExemple
            // 
            this.txtExemple.Location = new System.Drawing.Point(152, 81);
            this.txtExemple.Name = "txtExemple";
            this.txtExemple.Size = new System.Drawing.Size(406, 20);
            this.txtExemple.TabIndex = 3;
            this.txtExemple.Enter += new System.EventHandler(this.textboxEntry);
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(152, 56);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(205, 20);
            this.txtEnglish.TabIndex = 2;
            this.txtEnglish.Enter += new System.EventHandler(this.textboxEntry);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(152, 31);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(205, 20);
            this.txtSource.TabIndex = 1;
            this.txtSource.Enter += new System.EventHandler(this.textboxEntry);
            // 
            // labExample
            // 
            this.labExample.AutoSize = true;
            this.labExample.Location = new System.Drawing.Point(12, 85);
            this.labExample.Name = "labExample";
            this.labExample.Size = new System.Drawing.Size(61, 13);
            this.labExample.TabIndex = 14;
            this.labExample.Text = "Example(s):";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Location = new System.Drawing.Point(12, 60);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(44, 13);
            this.labEnglish.TabIndex = 13;
            this.labEnglish.Text = "English:";
            // 
            // labSourceEntry
            // 
            this.labSourceEntry.AutoSize = true;
            this.labSourceEntry.Location = new System.Drawing.Point(12, 35);
            this.labSourceEntry.Name = "labSourceEntry";
            this.labSourceEntry.Size = new System.Drawing.Size(133, 13);
            this.labSourceEntry.TabIndex = 12;
            this.labSourceEntry.Text = "Entry in Source Language:";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(152, 6);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(205, 20);
            this.txtKeyword.TabIndex = 0;
            this.txtKeyword.Enter += new System.EventHandler(this.textboxEntry);
            // 
            // labKeyword
            // 
            this.labKeyword.AutoSize = true;
            this.labKeyword.Location = new System.Drawing.Point(12, 10);
            this.labKeyword.Name = "labKeyword";
            this.labKeyword.Size = new System.Drawing.Size(51, 13);
            this.labKeyword.TabIndex = 19;
            this.labKeyword.Text = "Keyword:";
            // 
            // EditEntry
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 446);
            this.ControlBox = false;
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.labKeyword);
            this.Controls.Add(this.pnlKeys);
            this.Controls.Add(this.txtExemple);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.labExample);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labSourceEntry);
            this.Controls.Add(this.pnlEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEntry";
            this.pnlEntry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEntry;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlKeys;
        private System.Windows.Forms.TextBox txtExemple;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label labExample;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labSourceEntry;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label labKeyword;
    }
}