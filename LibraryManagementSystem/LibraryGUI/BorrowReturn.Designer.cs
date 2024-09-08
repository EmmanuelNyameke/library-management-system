namespace LibraryGUI
{
    partial class BorrowReturn
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
            this.lblBorrowReturn = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnViewBorrowedBooks = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBorrowReturn
            // 
            this.lblBorrowReturn.AutoSize = true;
            this.lblBorrowReturn.BackColor = System.Drawing.Color.DarkRed;
            this.lblBorrowReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBorrowReturn.Location = new System.Drawing.Point(55, 35);
            this.lblBorrowReturn.Name = "lblBorrowReturn";
            this.lblBorrowReturn.Size = new System.Drawing.Size(484, 45);
            this.lblBorrowReturn.TabIndex = 9;
            this.lblBorrowReturn.Text = "Borrowing And Returning Books";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Firebrick;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(313, 246);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Firebrick;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Location = new System.Drawing.Point(313, 127);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 39);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnViewBorrowedBooks
            // 
            this.btnViewBorrowedBooks.BackColor = System.Drawing.Color.Firebrick;
            this.btnViewBorrowedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBorrowedBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBorrowedBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewBorrowedBooks.Location = new System.Drawing.Point(95, 246);
            this.btnViewBorrowedBooks.Name = "btnViewBorrowedBooks";
            this.btnViewBorrowedBooks.Size = new System.Drawing.Size(177, 39);
            this.btnViewBorrowedBooks.TabIndex = 6;
            this.btnViewBorrowedBooks.Text = "View Borrowed Books";
            this.btnViewBorrowedBooks.UseVisualStyleBackColor = false;
            this.btnViewBorrowedBooks.Click += new System.EventHandler(this.btnViewBorrowedBooks_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrow.Location = new System.Drawing.Point(95, 127);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(177, 39);
            this.btnBorrow.TabIndex = 5;
            this.btnBorrow.Text = "Borrow Book";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // BorrowReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.lblBorrowReturn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnViewBorrowedBooks);
            this.Controls.Add(this.btnBorrow);
            this.Name = "BorrowReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorrowReturn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnViewBorrowedBooks;
        private System.Windows.Forms.Button btnBorrow;
    }
}