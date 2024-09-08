namespace LibraryGUI
{
    partial class ManageUsers
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
            this.lblManageUser = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManageUser
            // 
            this.lblManageUser.AutoSize = true;
            this.lblManageUser.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManageUser.Location = new System.Drawing.Point(201, 27);
            this.lblManageUser.Name = "lblManageUser";
            this.lblManageUser.Size = new System.Drawing.Size(283, 45);
            this.lblManageUser.TabIndex = 14;
            this.lblManageUser.Text = "User Management";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(347, 268);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 39);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back\r\n";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.BackColor = System.Drawing.Color.White;
            this.btnDeactivateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivateUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeactivateUser.Location = new System.Drawing.Point(347, 149);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(177, 39);
            this.btnDeactivateUser.TabIndex = 12;
            this.btnDeactivateUser.Text = "Deactivate User";
            this.btnDeactivateUser.UseVisualStyleBackColor = false;
            this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.BackColor = System.Drawing.Color.White;
            this.btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUserList.Location = new System.Drawing.Point(129, 268);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(177, 39);
            this.btnUserList.TabIndex = 11;
            this.btnUserList.Text = "View User List";
            this.btnUserList.UseVisualStyleBackColor = false;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.White;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddUser.Location = new System.Drawing.Point(129, 149);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(177, 39);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(653, 331);
            this.Controls.Add(this.lblManageUser);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnUserList);
            this.Controls.Add(this.btnAddUser);
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.Button btnAddUser;
    }
}