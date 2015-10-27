namespace ContactUI
{
    partial class Form1
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
            this.LFirstName = new System.Windows.Forms.Label();
            this.tFirstName = new System.Windows.Forms.TextBox();
            this.tLastName = new System.Windows.Forms.TextBox();
            this.LLastName = new System.Windows.Forms.Label();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.LMobile = new System.Windows.Forms.Label();
            this.tPhoneNumber = new System.Windows.Forms.TextBox();
            this.ContactList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.lInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LFirstName
            // 
            this.LFirstName.AutoSize = true;
            this.LFirstName.Location = new System.Drawing.Point(28, 54);
            this.LFirstName.Name = "LFirstName";
            this.LFirstName.Size = new System.Drawing.Size(60, 13);
            this.LFirstName.TabIndex = 0;
            this.LFirstName.Text = "First Name:";
            // 
            // tFirstName
            // 
            this.tFirstName.Location = new System.Drawing.Point(102, 51);
            this.tFirstName.Name = "tFirstName";
            this.tFirstName.Size = new System.Drawing.Size(166, 20);
            this.tFirstName.TabIndex = 1;
            // 
            // tLastName
            // 
            this.tLastName.Location = new System.Drawing.Point(102, 78);
            this.tLastName.Name = "tLastName";
            this.tLastName.Size = new System.Drawing.Size(166, 20);
            this.tLastName.TabIndex = 2;
            // 
            // LLastName
            // 
            this.LLastName.AutoSize = true;
            this.LLastName.Location = new System.Drawing.Point(28, 81);
            this.LLastName.Name = "LLastName";
            this.LLastName.Size = new System.Drawing.Size(61, 13);
            this.LLastName.TabIndex = 3;
            this.LLastName.Text = "Last Name:";
            // 
            // BUpdate
            // 
            this.BUpdate.Location = new System.Drawing.Point(31, 134);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(75, 23);
            this.BUpdate.TabIndex = 4;
            this.BUpdate.Text = "Update";
            this.BUpdate.UseVisualStyleBackColor = true;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(112, 134);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 5;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BDelete
            // 
            this.BDelete.Location = new System.Drawing.Point(193, 134);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(75, 23);
            this.BDelete.TabIndex = 6;
            this.BDelete.Text = "Delete";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // LMobile
            // 
            this.LMobile.AutoSize = true;
            this.LMobile.Location = new System.Drawing.Point(28, 108);
            this.LMobile.Name = "LMobile";
            this.LMobile.Size = new System.Drawing.Size(41, 13);
            this.LMobile.TabIndex = 7;
            this.LMobile.Text = "Mobile:";
            // 
            // tPhoneNumber
            // 
            this.tPhoneNumber.Location = new System.Drawing.Point(102, 105);
            this.tPhoneNumber.Name = "tPhoneNumber";
            this.tPhoneNumber.Size = new System.Drawing.Size(166, 20);
            this.tPhoneNumber.TabIndex = 8;
            // 
            // ContactList
            // 
            this.ContactList.FormattingEnabled = true;
            this.ContactList.Location = new System.Drawing.Point(290, 40);
            this.ContactList.Name = "ContactList";
            this.ContactList.Size = new System.Drawing.Size(245, 147);
            this.ContactList.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contacts";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(31, 21);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 13);
            this.lStatus.TabIndex = 11;
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(293, 194);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(133, 13);
            this.lInfo.TabIndex = 12;
            this.lInfo.Text = "Select a contact to update";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 214);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContactList);
            this.Controls.Add(this.tPhoneNumber);
            this.Controls.Add(this.LMobile);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.BUpdate);
            this.Controls.Add(this.LLastName);
            this.Controls.Add(this.tLastName);
            this.Controls.Add(this.tFirstName);
            this.Controls.Add(this.LFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFirstName;
        private System.Windows.Forms.TextBox tFirstName;
        private System.Windows.Forms.TextBox tLastName;
        private System.Windows.Forms.Label LLastName;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Label LMobile;
        private System.Windows.Forms.TextBox tPhoneNumber;
        private System.Windows.Forms.ListBox ContactList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lInfo;
    }
}

