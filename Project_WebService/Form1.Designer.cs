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
            this.lblPrevUsername = new System.Windows.Forms.Label();
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblNbreCopy = new System.Windows.Forms.Label();
            this.lblPrevCopy = new System.Windows.Forms.Label();
            this.txtNbreCopyToPrint = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnConnectUsername = new System.Windows.Forms.Button();
            this.btnConnectWithId = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrevUsername
            // 
            this.lblPrevUsername.AutoSize = true;
            this.lblPrevUsername.Location = new System.Drawing.Point(32, 102);
            this.lblPrevUsername.Name = "lblPrevUsername";
            this.lblPrevUsername.Size = new System.Drawing.Size(73, 17);
            this.lblPrevUsername.TabIndex = 1;
            this.lblPrevUsername.Text = "Username";
            // 
            // lblPrevFirstname
            // 
            this.lblPrevFirstname.AutoSize = true;
            this.lblPrevFirstname.Location = new System.Drawing.Point(32, 150);
            this.lblPrevFirstname.Name = "lblPrevFirstname";
            this.lblPrevFirstname.Size = new System.Drawing.Size(70, 17);
            this.lblPrevFirstname.TabIndex = 2;
            this.lblPrevFirstname.Text = "Firstname";
            // 
            // lblPrevLastname
            // 
            this.lblPrevLastname.AutoSize = true;
            this.lblPrevLastname.Location = new System.Drawing.Point(32, 200);
            this.lblPrevLastname.Name = "lblPrevLastname";
            this.lblPrevLastname.Size = new System.Drawing.Size(70, 17);
            this.lblPrevLastname.TabIndex = 3;
            this.lblPrevLastname.Text = "Lastname";
            // 
            // lblPrevAmount
            // 
            this.lblPrevAmount.AutoSize = true;
            this.lblPrevAmount.Location = new System.Drawing.Point(32, 254);
            this.lblPrevAmount.Name = "lblPrevAmount";
            this.lblPrevAmount.Size = new System.Drawing.Size(56, 17);
            this.lblPrevAmount.TabIndex = 4;
            this.lblPrevAmount.Text = "Amount";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(120, 150);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(13, 17);
            this.lblFirstname.TabIndex = 5;
            this.lblFirstname.Text = "-";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(120, 200);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(13, 17);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "-";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(120, 254);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(13, 17);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "-";
            // 
            // btnAddViaId
            // 
            this.btnAddViaId.Enabled = false;
            this.btnAddViaId.Location = new System.Drawing.Point(12, 399);
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
            this.txtAmount.Location = new System.Drawing.Point(72, 361);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(172, 22);
            this.txtAmount.TabIndex = 11;
            // 
            // lbUsername
            // 
            this.lbUsername.FormattingEnabled = true;
            this.lbUsername.ItemHeight = 16;
            this.lbUsername.Location = new System.Drawing.Point(396, 22);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(159, 52);
            this.lbUsername.TabIndex = 12;
            this.lbUsername.SelectedIndexChanged += new System.EventHandler(this.lbUsername_SelectedIndexChanged);
            // 
            // btnAddViaUsername
            // 
            this.btnAddViaUsername.Enabled = false;
            this.btnAddViaUsername.Location = new System.Drawing.Point(158, 399);
            this.btnAddViaUsername.Name = "btnAddViaUsername";
            this.btnAddViaUsername.Size = new System.Drawing.Size(140, 23);
            this.btnAddViaUsername.TabIndex = 13;
            this.btnAddViaUsername.Text = "Add via Username";
            this.btnAddViaUsername.UseVisualStyleBackColor = true;
            this.btnAddViaUsername.Click += new System.EventHandler(this.btnAddViaUsername_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(12, 452);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 23);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblNbreCopy
            // 
            this.lblNbreCopy.AutoSize = true;
            this.lblNbreCopy.Location = new System.Drawing.Point(120, 301);
            this.lblNbreCopy.Name = "lblNbreCopy";
            this.lblNbreCopy.Size = new System.Drawing.Size(13, 17);
            this.lblNbreCopy.TabIndex = 15;
            this.lblNbreCopy.Text = "-";
            // 
            // lblPrevCopy
            // 
            this.lblPrevCopy.AutoSize = true;
            this.lblPrevCopy.Location = new System.Drawing.Point(32, 301);
            this.lblPrevCopy.Name = "lblPrevCopy";
            this.lblPrevCopy.Size = new System.Drawing.Size(75, 17);
            this.lblPrevCopy.TabIndex = 17;
            this.lblPrevCopy.Text = "Nbre Copy";
            // 
            // txtNbreCopyToPrint
            // 
            this.txtNbreCopyToPrint.Enabled = false;
            this.txtNbreCopyToPrint.Location = new System.Drawing.Point(172, 452);
            this.txtNbreCopyToPrint.Name = "txtNbreCopyToPrint";
            this.txtNbreCopyToPrint.Size = new System.Drawing.Size(100, 22);
            this.txtNbreCopyToPrint.TabIndex = 18;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(16, 492);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 19;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(251, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 20;
            // 
            // btnConnectUsername
            // 
            this.btnConnectUsername.Location = new System.Drawing.Point(35, 22);
            this.btnConnectUsername.Name = "btnConnectUsername";
            this.btnConnectUsername.Size = new System.Drawing.Size(209, 23);
            this.btnConnectUsername.TabIndex = 21;
            this.btnConnectUsername.Text = "Connect with Username";
            this.btnConnectUsername.UseVisualStyleBackColor = true;
            this.btnConnectUsername.Click += new System.EventHandler(this.btnConnectUsername_Click);
            // 
            // btnConnectWithId
            // 
            this.btnConnectWithId.Location = new System.Drawing.Point(35, 51);
            this.btnConnectWithId.Name = "btnConnectWithId";
            this.btnConnectWithId.Size = new System.Drawing.Size(209, 23);
            this.btnConnectWithId.TabIndex = 22;
            this.btnConnectWithId.Text = "Connect with Id";
            this.btnConnectWithId.UseVisualStyleBackColor = true;
            this.btnConnectWithId.Click += new System.EventHandler(this.btnConnectWithId_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(251, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 23;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(120, 102);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(13, 17);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 569);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnConnectWithId);
            this.Controls.Add(this.btnConnectUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtNbreCopyToPrint);
            this.Controls.Add(this.lblPrevCopy);
            this.Controls.Add(this.lblNbreCopy);
            this.Controls.Add(this.btnPrint);
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
            this.Controls.Add(this.lblPrevUsername);
            this.Name = "Form1";
            this.Text = "Project WebService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrevUsername;
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblNbreCopy;
        private System.Windows.Forms.Label lblPrevCopy;
        private System.Windows.Forms.TextBox txtNbreCopyToPrint;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnConnectUsername;
        private System.Windows.Forms.Button btnConnectWithId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblUsername;
    }
}

