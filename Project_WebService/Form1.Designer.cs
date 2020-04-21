namespace Project_WebService
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPrevFirstname = new System.Windows.Forms.Label();
            this.lblPrevLastname = new System.Windows.Forms.Label();
            this.lblPrevAmount = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnAddViaId = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.ListBox();
            this.btnAddViaUsername = new System.Windows.Forms.Button();
            this.btnNbreCopy = new System.Windows.Forms.Button();
            this.lblNbreCopy = new System.Windows.Forms.Label();
            this.lblPrevCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(32, 34);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPrevFirstname
            // 
            this.lblPrevFirstname.AutoSize = true;
            this.lblPrevFirstname.Location = new System.Drawing.Point(32, 82);
            this.lblPrevFirstname.Name = "lblPrevFirstname";
            this.lblPrevFirstname.Size = new System.Drawing.Size(70, 17);
            this.lblPrevFirstname.TabIndex = 2;
            this.lblPrevFirstname.Text = "Firstname";
            // 
            // lblPrevLastname
            // 
            this.lblPrevLastname.AutoSize = true;
            this.lblPrevLastname.Location = new System.Drawing.Point(32, 132);
            this.lblPrevLastname.Name = "lblPrevLastname";
            this.lblPrevLastname.Size = new System.Drawing.Size(70, 17);
            this.lblPrevLastname.TabIndex = 3;
            this.lblPrevLastname.Text = "Lastname";
            // 
            // lblPrevAmount
            // 
            this.lblPrevAmount.AutoSize = true;
            this.lblPrevAmount.Location = new System.Drawing.Point(32, 186);
            this.lblPrevAmount.Name = "lblPrevAmount";
            this.lblPrevAmount.Size = new System.Drawing.Size(56, 17);
            this.lblPrevAmount.TabIndex = 4;
            this.lblPrevAmount.Text = "Amount";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(120, 82);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(13, 17);
            this.lblFirstname.TabIndex = 5;
            this.lblFirstname.Text = "-";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(120, 132);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(13, 17);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "-";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(120, 186);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(13, 17);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "-";
            // 
            // btnAddViaId
            // 
            this.btnAddViaId.Enabled = false;
            this.btnAddViaId.Location = new System.Drawing.Point(12, 331);
            this.btnAddViaId.Name = "btnAddViaId";
            this.btnAddViaId.Size = new System.Drawing.Size(140, 23);
            this.btnAddViaId.TabIndex = 8;
            this.btnAddViaId.Text = "Add via ID";
            this.btnAddViaId.UseVisualStyleBackColor = true;
            this.btnAddViaId.Click += new System.EventHandler(this.btnAddViaId_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(72, 293);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(172, 22);
            this.txtAmount.TabIndex = 11;
            // 
            // lbUsername
            // 
            this.lbUsername.FormattingEnabled = true;
            this.lbUsername.ItemHeight = 16;
            this.lbUsername.Location = new System.Drawing.Point(123, 24);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(159, 36);
            this.lbUsername.TabIndex = 12;
            this.lbUsername.SelectedIndexChanged += new System.EventHandler(this.lbUsername_SelectedIndexChanged);
            // 
            // btnAddViaUsername
            // 
            this.btnAddViaUsername.Enabled = false;
            this.btnAddViaUsername.Location = new System.Drawing.Point(158, 331);
            this.btnAddViaUsername.Name = "btnAddViaUsername";
            this.btnAddViaUsername.Size = new System.Drawing.Size(140, 23);
            this.btnAddViaUsername.TabIndex = 13;
            this.btnAddViaUsername.Text = "Add via Username";
            this.btnAddViaUsername.UseVisualStyleBackColor = true;
            // 
            // btnNbreCopy
            // 
            this.btnNbreCopy.Location = new System.Drawing.Point(0, 0);
            this.btnNbreCopy.Name = "btnNbreCopy";
            this.btnNbreCopy.Size = new System.Drawing.Size(75, 23);
            this.btnNbreCopy.TabIndex = 16;
            // 
            // lblNbreCopy
            // 
            this.lblNbreCopy.AutoSize = true;
            this.lblNbreCopy.Location = new System.Drawing.Point(120, 233);
            this.lblNbreCopy.Name = "lblNbreCopy";
            this.lblNbreCopy.Size = new System.Drawing.Size(13, 17);
            this.lblNbreCopy.TabIndex = 15;
            this.lblNbreCopy.Text = "-";
            // 
            // lblPrevCopy
            // 
            this.lblPrevCopy.AutoSize = true;
            this.lblPrevCopy.Location = new System.Drawing.Point(32, 233);
            this.lblPrevCopy.Name = "lblPrevCopy";
            this.lblPrevCopy.Size = new System.Drawing.Size(75, 17);
            this.lblPrevCopy.TabIndex = 17;
            this.lblPrevCopy.Text = "Nbre Copy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.lblPrevCopy);
            this.Controls.Add(this.lblNbreCopy);
            this.Controls.Add(this.btnNbreCopy);
            this.Controls.Add(this.btnAddViaUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnAddViaId);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblPrevAmount);
            this.Controls.Add(this.lblPrevLastname);
            this.Controls.Add(this.lblPrevFirstname);
            this.Controls.Add(this.lblUsername);
            this.Name = "Form1";
            this.Text = "Project WebService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPrevFirstname;
        private System.Windows.Forms.Label lblPrevLastname;
        private System.Windows.Forms.Label lblPrevAmount;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnAddViaId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ListBox lbUsername;
        private System.Windows.Forms.Button btnAddViaUsername;
        private System.Windows.Forms.Button btnNbreCopy;
        private System.Windows.Forms.Label lblNbreCopy;
        private System.Windows.Forms.Label lblPrevCopy;
    }
}

