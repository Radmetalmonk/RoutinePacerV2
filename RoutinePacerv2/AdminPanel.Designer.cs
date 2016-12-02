namespace RoutinePacerv2
{
    partial class F_AdminPanel
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
            this.LB_Admin = new System.Windows.Forms.ListBox();
            this.B_NewUser = new System.Windows.Forms.Button();
            this.B_SelectUser = new System.Windows.Forms.Button();
            this.B_DeleteUser = new System.Windows.Forms.Button();
            this.B_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Admin
            // 
            this.LB_Admin.FormattingEnabled = true;
            this.LB_Admin.Location = new System.Drawing.Point(13, 13);
            this.LB_Admin.Name = "LB_Admin";
            this.LB_Admin.Size = new System.Drawing.Size(321, 212);
            this.LB_Admin.TabIndex = 0;
            // 
            // B_NewUser
            // 
            this.B_NewUser.Location = new System.Drawing.Point(13, 232);
            this.B_NewUser.Name = "B_NewUser";
            this.B_NewUser.Size = new System.Drawing.Size(75, 23);
            this.B_NewUser.TabIndex = 1;
            this.B_NewUser.Text = "New User";
            this.B_NewUser.UseVisualStyleBackColor = true;
            this.B_NewUser.Click += new System.EventHandler(this.B_NewUser_Click);
            // 
            // B_SelectUser
            // 
            this.B_SelectUser.Location = new System.Drawing.Point(95, 232);
            this.B_SelectUser.Name = "B_SelectUser";
            this.B_SelectUser.Size = new System.Drawing.Size(75, 23);
            this.B_SelectUser.TabIndex = 2;
            this.B_SelectUser.Text = "Select User";
            this.B_SelectUser.UseVisualStyleBackColor = true;
            this.B_SelectUser.Click += new System.EventHandler(this.B_SelectUser_Click);
            // 
            // B_DeleteUser
            // 
            this.B_DeleteUser.Location = new System.Drawing.Point(177, 232);
            this.B_DeleteUser.Name = "B_DeleteUser";
            this.B_DeleteUser.Size = new System.Drawing.Size(75, 23);
            this.B_DeleteUser.TabIndex = 3;
            this.B_DeleteUser.Text = "Delete User";
            this.B_DeleteUser.UseVisualStyleBackColor = true;
            // 
            // B_Quit
            // 
            this.B_Quit.Location = new System.Drawing.Point(259, 232);
            this.B_Quit.Name = "B_Quit";
            this.B_Quit.Size = new System.Drawing.Size(75, 23);
            this.B_Quit.TabIndex = 4;
            this.B_Quit.Text = "Quit";
            this.B_Quit.UseVisualStyleBackColor = true;
            // 
            // F_AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 271);
            this.Controls.Add(this.B_Quit);
            this.Controls.Add(this.B_DeleteUser);
            this.Controls.Add(this.B_SelectUser);
            this.Controls.Add(this.B_NewUser);
            this.Controls.Add(this.LB_Admin);
            this.Name = "F_AdminPanel";
            this.Text = "Routine Pacer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Admin;
        private System.Windows.Forms.Button B_NewUser;
        private System.Windows.Forms.Button B_SelectUser;
        private System.Windows.Forms.Button B_DeleteUser;
        private System.Windows.Forms.Button B_Quit;
    }
}

