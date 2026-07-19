namespace FIleSearchWindows
{
    partial class Form1
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
            this.txtDir = new TextBox();
            btnSearch = new Button();
            listFiles = new ListBox();
            SuspendLayout();
            // 
            // txtDir
            // 
            this.txtDir.Location = new Point(37, 40);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new Size(200, 39);
            this.txtDir.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(277, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search Now";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listFiles
            // 
            listFiles.FormattingEnabled = true;
            listFiles.Location = new Point(37, 124);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(751, 420);
            listFiles.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(listFiles);
            Controls.Add(btnSearch);
            Controls.Add(this.txtDir);
            Name = "Form1";
            Text = "File Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDir;
        private Button btnSearch;
        private ListBox listFiles;
    }
}
