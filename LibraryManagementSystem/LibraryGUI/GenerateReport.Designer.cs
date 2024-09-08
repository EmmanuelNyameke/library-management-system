namespace LibraryGUI
{
    partial class GenerateReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnActiveUsers = new System.Windows.Forms.Button();
            this.btnPopularBooks = new System.Windows.Forms.Button();
            this.btnLibraryStats = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Generator";
            // 
            // btnActiveUsers
            // 
            this.btnActiveUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActiveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActiveUsers.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiveUsers.Location = new System.Drawing.Point(248, 91);
            this.btnActiveUsers.Name = "btnActiveUsers";
            this.btnActiveUsers.Size = new System.Drawing.Size(172, 49);
            this.btnActiveUsers.TabIndex = 1;
            this.btnActiveUsers.Text = "Active Users";
            this.btnActiveUsers.UseVisualStyleBackColor = true;
            this.btnActiveUsers.Click += new System.EventHandler(this.btnActiveUsers_Click);
            // 
            // btnPopularBooks
            // 
            this.btnPopularBooks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPopularBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPopularBooks.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopularBooks.Location = new System.Drawing.Point(34, 91);
            this.btnPopularBooks.Name = "btnPopularBooks";
            this.btnPopularBooks.Size = new System.Drawing.Size(172, 49);
            this.btnPopularBooks.TabIndex = 2;
            this.btnPopularBooks.Text = "Popular Books";
            this.btnPopularBooks.UseVisualStyleBackColor = true;
            this.btnPopularBooks.Click += new System.EventHandler(this.btnPopularBooks_Click);
            // 
            // btnLibraryStats
            // 
            this.btnLibraryStats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLibraryStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLibraryStats.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibraryStats.Location = new System.Drawing.Point(34, 217);
            this.btnLibraryStats.Name = "btnLibraryStats";
            this.btnLibraryStats.Size = new System.Drawing.Size(172, 49);
            this.btnLibraryStats.TabIndex = 3;
            this.btnLibraryStats.Text = "Library Stats";
            this.btnLibraryStats.UseVisualStyleBackColor = true;
            this.btnLibraryStats.Click += new System.EventHandler(this.btnLibraryStats_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(248, 217);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 49);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 333);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLibraryStats);
            this.Controls.Add(this.btnPopularBooks);
            this.Controls.Add(this.btnActiveUsers);
            this.Controls.Add(this.label1);
            this.Name = "GenerateReport";
            this.Text = "GenerateReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActiveUsers;
        private System.Windows.Forms.Button btnPopularBooks;
        private System.Windows.Forms.Button btnLibraryStats;
        private System.Windows.Forms.Button btnBack;
    }
}