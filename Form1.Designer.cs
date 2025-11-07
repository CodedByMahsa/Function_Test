namespace Function
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtText = new TextBox();
            TxtChar = new TextBox();
            BtnWordsList = new Button();
            BtnNumOfChars = new Button();
            BtnNumOfWords = new Button();
            SuspendLayout();
            // 
            // TxtText
            // 
            TxtText.Location = new Point(59, 62);
            TxtText.Multiline = true;
            TxtText.Name = "TxtText";
            TxtText.Size = new Size(378, 50);
            TxtText.TabIndex = 0;
            TxtText.KeyPress += TxtText_KeyPress;
            // 
            // TxtChar
            // 
            TxtChar.Location = new Point(59, 150);
            TxtChar.Multiline = true;
            TxtChar.Name = "TxtChar";
            TxtChar.Size = new Size(378, 50);
            TxtChar.TabIndex = 0;
            TxtChar.KeyPress += TxtChar_KeyPress;
            // 
            // BtnWordsList
            // 
            BtnWordsList.Location = new Point(59, 242);
            BtnWordsList.Name = "BtnWordsList";
            BtnWordsList.Size = new Size(109, 46);
            BtnWordsList.TabIndex = 1;
            BtnWordsList.Text = "لیست کلمات";
            BtnWordsList.UseVisualStyleBackColor = true;
            BtnWordsList.Click += BtnWordsList_Click;
            // 
            // BtnNumOfChars
            // 
            BtnNumOfChars.Location = new Point(194, 242);
            BtnNumOfChars.Name = "BtnNumOfChars";
            BtnNumOfChars.Size = new Size(109, 46);
            BtnNumOfChars.TabIndex = 1;
            BtnNumOfChars.Text = "تعداد حرف";
            BtnNumOfChars.UseVisualStyleBackColor = true;
            BtnNumOfChars.Click += BtnNumOfChars_Click;
            // 
            // BtnNumOfWords
            // 
            BtnNumOfWords.Location = new Point(328, 242);
            BtnNumOfWords.Name = "BtnNumOfWords";
            BtnNumOfWords.Size = new Size(109, 46);
            BtnNumOfWords.TabIndex = 1;
            BtnNumOfWords.Text = "تعداد کلمه";
            BtnNumOfWords.UseVisualStyleBackColor = true;
            BtnNumOfWords.Click += BtnNumOfWords_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 346);
            Controls.Add(BtnNumOfWords);
            Controls.Add(BtnNumOfChars);
            Controls.Add(BtnWordsList);
            Controls.Add(TxtChar);
            Controls.Add(TxtText);
            Name = "FrmMain";
            Text = "FrmMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtText;
        private TextBox TxtChar;
        private Button BtnWordsList;
        private Button BtnNumOfChars;
        private Button BtnNumOfWords;
    }
}
