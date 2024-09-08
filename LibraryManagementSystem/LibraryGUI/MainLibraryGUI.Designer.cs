namespace LibraryGUI
{
    partial class MainLibraryGUI
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
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnBorrowReturn = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.BackColor = System.Drawing.Color.Tomato;
            this.btnManageBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageBooks.Location = new System.Drawing.Point(102, 110);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(177, 39);
            this.btnManageBooks.TabIndex = 0;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = false;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnBorrowReturn
            // 
            this.btnBorrowReturn.BackColor = System.Drawing.Color.Tomato;
            this.btnBorrowReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrowReturn.Location = new System.Drawing.Point(102, 229);
            this.btnBorrowReturn.Name = "btnBorrowReturn";
            this.btnBorrowReturn.Size = new System.Drawing.Size(177, 39);
            this.btnBorrowReturn.TabIndex = 1;
            this.btnBorrowReturn.Text = "Borrow/Return";
            this.btnBorrowReturn.UseVisualStyleBackColor = false;
            this.btnBorrowReturn.Click += new System.EventHandler(this.btnBorrowReturn_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.Tomato;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageUsers.Location = new System.Drawing.Point(320, 110);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(177, 39);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Tomato;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.Location = new System.Drawing.Point(320, 229);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(177, 39);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(197, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "IPMC Library";
            // 
            // MainLibraryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(623, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnBorrowReturn);
            this.Controls.Add(this.btnManageBooks);
            this.Name = "MainLibraryGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPMC Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnBorrowReturn;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label label1;
    }
}