namespace MyApp.WinForm
{
    partial class ViewUser
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
            lblForename = new System.Windows.Forms.Label();
            lblSurname = new System.Windows.Forms.Label();
            lblIsActive = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            lblDOB = new System.Windows.Forms.Label();
            LogNumber = new System.Windows.Forms.ColumnHeader();
            DateTime = new System.Windows.Forms.ColumnHeader();
            UserForename = new System.Windows.Forms.ColumnHeader();
            UserSurname = new System.Windows.Forms.ColumnHeader();
            LogMessage = new System.Windows.Forms.ColumnHeader();
            listLogMessages = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(11, 9);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 29);
            label1.TabIndex = 0;
            label1.Text = "View User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 262);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Forename:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(11, 306);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Surname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(11, 348);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Is Active:";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Location = new System.Drawing.Point(195, 262);
            lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblForename.Name = "lblForename";
            lblForename.Size = new System.Drawing.Size(96, 20);
            lblForename.TabIndex = 4;
            lblForename.Text = "[FORENAME]";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new System.Drawing.Point(195, 306);
            lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(88, 20);
            lblSurname.TabIndex = 5;
            lblSurname.Text = "[SURNAME]";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new System.Drawing.Point(195, 348);
            lblIsActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new System.Drawing.Size(79, 20);
            lblIsActive.TabIndex = 6;
            lblIsActive.Text = "[ISACTIVE]";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(621, 373);
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
            label5.Location = new System.Drawing.Point(11, 391);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(97, 20);
            label5.TabIndex = 8;
            label5.Text = "Date of Birth:";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new System.Drawing.Point(195, 391);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new System.Drawing.Size(113, 20);
            lblDOB.TabIndex = 9;
            lblDOB.Text = "[DATEOFBIRTH]";
            // 
            // LogNumber
            // 
            LogNumber.Text = "Log Number";
            // 
            // DateTime
            // 
            DateTime.Text = "Date Time";
            // 
            // UserForename
            // 
            UserForename.Text = "Forname";
            // 
            // UserSurname
            // 
            UserSurname.Text = "Surname";
            // 
            // LogMessage
            // 
            LogMessage.Text = "Log Message";
            // 
            // listLogMessages
            // 
            listLogMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listLogMessages.Location = new System.Drawing.Point(12, 44);
            listLogMessages.Name = "listLogMessages";
            listLogMessages.Size = new System.Drawing.Size(715, 202);
            listLogMessages.TabIndex = 10;
            listLogMessages.UseCompatibleStateImageBehavior = false;
            listLogMessages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Log ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Log Level";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Timestamp";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Message";
            columnHeader4.Width = 500;
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(739, 438);
            Controls.Add(listLogMessages);
            Controls.Add(lblDOB);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(lblIsActive);
            Controls.Add(lblSurname);
            Controls.Add(lblForename);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "ViewUser";
            Text = "ViewUser";
            Load += ViewUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.ColumnHeader LogNumber;
        private System.Windows.Forms.ColumnHeader DateTime;
        private System.Windows.Forms.ColumnHeader UserForename;
        private System.Windows.Forms.ColumnHeader UserSurname;
        private System.Windows.Forms.ColumnHeader LogMessage;
        private System.Windows.Forms.ListView listLogMessages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}