namespace cafe_billing
{
    partial class frmEnter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUserName = new Label();
            LblPassword = new Label();
            btnEnter = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(105, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(255, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cafe Restaurant";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 20.25F);
            lblUserName.Location = new Point(44, 119);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(161, 37);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name :";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 20.25F);
            LblPassword.Location = new Point(64, 234);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(141, 37);
            LblPassword.TabIndex = 2;
            LblPassword.Text = "Password :";
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI", 20.25F);
            btnEnter.Location = new Point(171, 338);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(139, 57);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Log in";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 20.25F);
            txtUserName.Location = new Point(234, 119);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(210, 43);
            txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 20.25F);
            txtPassword.Location = new Point(234, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 43);
            txtPassword.TabIndex = 5;
            // 
            // frmEnter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 541);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnEnter);
            Controls.Add(LblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblTitle);
            Name = "frmEnter";
            Text = "Cafe Restaurant";
            Load += frmEnter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUserName;
        private Label LblPassword;
        private Button btnEnter;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}
