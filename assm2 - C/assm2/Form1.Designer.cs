namespace assm2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbName = new Label();
            lbPass = new Label();
            txtName = new TextBox();
            txtPass = new TextBox();
            buttonLogin = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.Lime;
            lbName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbName.Location = new Point(88, 93);
            lbName.Name = "lbName";
            lbName.Size = new Size(160, 41);
            lbName.TabIndex = 0;
            lbName.Text = "UserName";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.BackColor = Color.Lime;
            lbPass.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbPass.Location = new Point(88, 193);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(147, 41);
            lbPass.TabIndex = 1;
            lbPass.Text = "Password";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 255, 128);
            txtName.Location = new Point(266, 93);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(363, 41);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(255, 255, 128);
            txtPass.Location = new Point(266, 193);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(363, 41);
            txtPass.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Lime;
            buttonLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(141, 288);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(154, 54);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Lime;
            buttonExit.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(407, 288);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(144, 54);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogin);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(lbPass);
            Controls.Add(lbName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbPass;
        private TextBox txtName;
        private TextBox txtPass;
        private Button buttonLogin;
        private Button buttonExit;
    }
}
