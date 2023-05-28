namespace MyApp.WinForm
{
    partial class EditUser
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtForename = new System.Windows.Forms.TextBox();
            txtIsActive = new System.Windows.Forms.TextBox();
            txtDateOfBirth = new System.Windows.Forms.TextBox();
            txtSurname = new System.Windows.Forms.TextBox();
            btnEditUser = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(9, 9);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 29);
            label1.TabIndex = 0;
            label1.Text = "Edit User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 97);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Forename:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 141);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Surname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 185);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Is Active:";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(365, 288);
            btnBack.Margin = new System.Windows.Forms.Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(106, 54);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(29, 229);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(97, 20);
            label5.TabIndex = 8;
            label5.Text = "Date of Birth:";
            // 
            // txtForename
            // 
            txtForename.Location = new System.Drawing.Point(167, 94);
            txtForename.Name = "txtForename";
            txtForename.Size = new System.Drawing.Size(284, 27);
            txtForename.TabIndex = 9;
            // 
            // txtIsActive
            // 
            txtIsActive.Location = new System.Drawing.Point(167, 182);
            txtIsActive.Name = "txtIsActive";
            txtIsActive.Size = new System.Drawing.Size(284, 27);
            txtIsActive.TabIndex = 11;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new System.Drawing.Point(167, 226);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new System.Drawing.Size(283, 27);
            txtDateOfBirth.TabIndex = 12;
            // 
            // txtSurname
            // 
            txtSurname.Location = new System.Drawing.Point(167, 138);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new System.Drawing.Size(284, 27);
            txtSurname.TabIndex = 10;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new System.Drawing.Point(11, 288);
            btnEditUser.Margin = new System.Windows.Forms.Padding(2);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new System.Drawing.Size(106, 54);
            btnEditUser.TabIndex = 13;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(482, 353);
            Controls.Add(btnEditUser);
            Controls.Add(txtSurname);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtIsActive);
            Controls.Add(txtForename);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "EditUser";
            Text = "AddUser";
            Load += ViewUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnAddUser_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtIsActive;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnEditUser;
    }
}