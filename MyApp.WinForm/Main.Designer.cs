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
            this.label1 = new System.Windows.Forms.Label();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Forename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActiveUsers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNonActiveUsers = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "User List";
            // 
            // lstUsers
            // 
            this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Forename,
            this.Surname,
            this.IsActive});
            this.lstUsers.Location = new System.Drawing.Point(37, 84);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(1207, 727);
            this.lstUsers.TabIndex = 2;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 162;
            // 
            // Forename
            // 
            this.Forename.Text = "Forename";
            this.Forename.Width = 412;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 456;
            // 
            // IsActive
            // 
            this.IsActive.Text = "Is Active";
            this.IsActive.Width = 164;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1454, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filters";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAllUsers);
            this.panel1.Controls.Add(this.btnNonActiveUsers);
            this.panel1.Controls.Add(this.btnActiveUsers);
            this.panel1.Location = new System.Drawing.Point(1319, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 250);
            this.panel1.TabIndex = 4;
            // 
            // btnActiveUsers
            // 
            this.btnActiveUsers.Location = new System.Drawing.Point(31, 98);
            this.btnActiveUsers.Name = "btnActiveUsers";
            this.btnActiveUsers.Size = new System.Drawing.Size(359, 51);
            this.btnActiveUsers.TabIndex = 0;
            this.btnActiveUsers.Text = "Active Users";
            this.btnActiveUsers.UseVisualStyleBackColor = true;
            this.btnActiveUsers.Click += new System.EventHandler(this.btnActiveUsers_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(1319, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 373);
            this.panel2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(359, 51);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1454, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Actions";
            // 
            // btnNonActiveUsers
            // 
            this.btnNonActiveUsers.Location = new System.Drawing.Point(31, 176);
            this.btnNonActiveUsers.Name = "btnNonActiveUsers";
            this.btnNonActiveUsers.Size = new System.Drawing.Size(359, 51);
            this.btnNonActiveUsers.TabIndex = 1;
            this.btnNonActiveUsers.Text = "Non Active";
            this.btnNonActiveUsers.UseVisualStyleBackColor = true;
            this.btnNonActiveUsers.Click += new System.EventHandler(this.btnNonActiveUsers_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(28, 202);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(359, 51);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(31, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(359, 51);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.Location = new System.Drawing.Point(31, 27);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(359, 51);
            this.btnAllUsers.TabIndex = 2;
            this.btnAllUsers.Text = "All Users";
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(28, 40);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(359, 51);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 847);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

