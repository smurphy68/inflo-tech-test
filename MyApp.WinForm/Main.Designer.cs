namespace MyApp.WinForm
{
    partial class Main
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
            lstUsers = new System.Windows.Forms.ListView();
            Id = new System.Windows.Forms.ColumnHeader();
            Forename = new System.Windows.Forms.ColumnHeader();
            Surname = new System.Windows.Forms.ColumnHeader();
            IsActive = new System.Windows.Forms.ColumnHeader();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnAllUsers = new System.Windows.Forms.Button();
            btnNonActiveUsers = new System.Windows.Forms.Button();
            btnActiveUsers = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            btnView = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(19, 21);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 29);
            label1.TabIndex = 0;
            label1.Text = "User List";
            // 
            // lstUsers
            // 
            lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Id, Forename, Surname, IsActive });
            lstUsers.Location = new System.Drawing.Point(25, 67);
            lstUsers.Margin = new System.Windows.Forms.Padding(2);
            lstUsers.MinimumSize = new System.Drawing.Size(806, 582);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new System.Drawing.Size(806, 582);
            lstUsers.TabIndex = 2;
            lstUsers.UseCompatibleStateImageBehavior = false;
            lstUsers.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 162;
            // 
            // Forename
            // 
            Forename.Text = "Forename";
            Forename.Width = 412;
            // 
            // Surname
            // 
            Surname.Text = "Surname";
            Surname.Width = 456;
            // 
            // IsActive
            // 
            IsActive.Text = "Is Active";
            IsActive.Width = 164;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(974, 21);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 29);
            label2.TabIndex = 3;
            label2.Text = "Filters";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAllUsers);
            panel1.Controls.Add(btnNonActiveUsers);
            panel1.Controls.Add(btnActiveUsers);
            panel1.Location = new System.Drawing.Point(879, 67);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(280, 200);
            panel1.TabIndex = 4;
            // 
            // btnAllUsers
            // 
            btnAllUsers.Location = new System.Drawing.Point(21, 22);
            btnAllUsers.Margin = new System.Windows.Forms.Padding(2);
            btnAllUsers.Name = "btnAllUsers";
            btnAllUsers.Size = new System.Drawing.Size(239, 41);
            btnAllUsers.TabIndex = 2;
            btnAllUsers.Text = "All Users";
            btnAllUsers.UseVisualStyleBackColor = true;
            btnAllUsers.Click += btnAllUsers_Click;
            // 
            // btnNonActiveUsers
            // 
            btnNonActiveUsers.Location = new System.Drawing.Point(21, 141);
            btnNonActiveUsers.Margin = new System.Windows.Forms.Padding(2);
            btnNonActiveUsers.Name = "btnNonActiveUsers";
            btnNonActiveUsers.Size = new System.Drawing.Size(239, 41);
            btnNonActiveUsers.TabIndex = 1;
            btnNonActiveUsers.Text = "Non Active";
            btnNonActiveUsers.UseVisualStyleBackColor = true;
            btnNonActiveUsers.Click += btnNonActiveUsers_Click;
            // 
            // btnActiveUsers
            // 
            btnActiveUsers.Location = new System.Drawing.Point(21, 78);
            btnActiveUsers.Margin = new System.Windows.Forms.Padding(2);
            btnActiveUsers.Name = "btnActiveUsers";
            btnActiveUsers.Size = new System.Drawing.Size(239, 41);
            btnActiveUsers.TabIndex = 0;
            btnActiveUsers.Text = "Active Users";
            btnActiveUsers.UseVisualStyleBackColor = true;
            btnActiveUsers.Click += btnActiveUsers_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnView);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new System.Drawing.Point(879, 350);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(280, 298);
            panel2.TabIndex = 6;
            // 
            // btnView
            // 
            btnView.Location = new System.Drawing.Point(19, 32);
            btnView.Margin = new System.Windows.Forms.Padding(2);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(239, 41);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(21, 226);
            btnDelete.Margin = new System.Windows.Forms.Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(239, 41);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(19, 162);
            btnEdit.Margin = new System.Windows.Forms.Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(239, 41);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(21, 97);
            btnAdd.Margin = new System.Windows.Forms.Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(239, 41);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(969, 304);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 29);
            label3.TabIndex = 5;
            label3.Text = "Actions";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1233, 678);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstUsers);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Main";
            Text = "Inflo Tech Test - Simon Murphy";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Forename;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader IsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActiveUsers;
        private System.Windows.Forms.Button btnNonActiveUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnView;
    }
}

