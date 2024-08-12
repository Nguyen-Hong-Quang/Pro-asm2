namespace assm2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnLogout = new Button();
            groupBox1 = new GroupBox();
            txtID = new TextBox();
            lbID = new Label();
            txtMember = new TextBox();
            lbMember = new Label();
            txtDiscription = new TextBox();
            lbDiscription = new Label();
            btnPrintBill = new Button();
            txtName = new TextBox();
            lbName = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            rbBussiness = new RadioButton();
            rbProductions = new RadioButton();
            rbPublicServices = new RadioButton();
            rbHouseHold = new RadioButton();
            txtThisMonth = new TextBox();
            txtLastMonth = new TextBox();
            lbThisMonth = new Label();
            lbLastMonth = new Label();
            lsvBill = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightCoral;
            btnLogout.Location = new Point(597, 235);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(84, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(lbID);
            groupBox1.Controls.Add(txtMember);
            groupBox1.Controls.Add(lbMember);
            groupBox1.Controls.Add(txtDiscription);
            groupBox1.Controls.Add(lbDiscription);
            groupBox1.Controls.Add(btnPrintBill);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lbName);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(rbBussiness);
            groupBox1.Controls.Add(rbProductions);
            groupBox1.Controls.Add(rbPublicServices);
            groupBox1.Controls.Add(rbHouseHold);
            groupBox1.Controls.Add(txtThisMonth);
            groupBox1.Controls.Add(txtLastMonth);
            groupBox1.Controls.Add(lbThisMonth);
            groupBox1.Controls.Add(lbLastMonth);
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1236, 282);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.Info;
            txtID.Location = new Point(539, 13);
            txtID.Name = "txtID";
            txtID.Size = new Size(257, 27);
            txtID.TabIndex = 27;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.BackColor = SystemColors.ActiveCaptionText;
            lbID.ForeColor = SystemColors.ButtonHighlight;
            lbID.Location = new Point(442, 16);
            lbID.Name = "lbID";
            lbID.Size = new Size(91, 20);
            lbID.TabIndex = 26;
            lbID.Text = "ID Customer";
            // 
            // txtMember
            // 
            txtMember.BackColor = SystemColors.Info;
            txtMember.Location = new Point(488, 109);
            txtMember.Multiline = true;
            txtMember.Name = "txtMember";
            txtMember.Size = new Size(147, 27);
            txtMember.TabIndex = 25;
            txtMember.UseWaitCursor = true;
            txtMember.Visible = false;
            // 
            // lbMember
            // 
            lbMember.AutoSize = true;
            lbMember.BackColor = SystemColors.ActiveCaptionText;
            lbMember.ForeColor = SystemColors.ButtonHighlight;
            lbMember.Location = new Point(488, 70);
            lbMember.Name = "lbMember";
            lbMember.Size = new Size(147, 20);
            lbMember.TabIndex = 24;
            lbMember.Text = "Number of members";
            lbMember.Visible = false;
            // 
            // txtDiscription
            // 
            txtDiscription.BackColor = SystemColors.Info;
            txtDiscription.Location = new Point(806, 42);
            txtDiscription.Multiline = true;
            txtDiscription.Name = "txtDiscription";
            txtDiscription.ReadOnly = true;
            txtDiscription.Size = new Size(365, 161);
            txtDiscription.TabIndex = 23;
            // 
            // lbDiscription
            // 
            lbDiscription.AutoSize = true;
            lbDiscription.BackColor = SystemColors.ActiveCaptionText;
            lbDiscription.ForeColor = SystemColors.ButtonHighlight;
            lbDiscription.Location = new Point(935, 16);
            lbDiscription.Name = "lbDiscription";
            lbDiscription.Size = new Size(81, 20);
            lbDiscription.TabIndex = 22;
            lbDiscription.Text = "Discription";
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = Color.Fuchsia;
            btnPrintBill.Location = new Point(469, 235);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(94, 29);
            btnPrintBill.TabIndex = 21;
            btnPrintBill.Text = "Print Bill";
            btnPrintBill.UseVisualStyleBackColor = false;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Info;
            txtName.Location = new Point(102, 16);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 27);
            txtName.TabIndex = 20;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.FromArgb(0, 0, 64);
            lbName.ForeColor = SystemColors.ButtonHighlight;
            lbName.Location = new Point(29, 16);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 19;
            lbName.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Location = new Point(332, 235);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Location = new Point(202, 235);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Yellow;
            btnAdd.Location = new Point(69, 235);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // rbBussiness
            // 
            rbBussiness.AutoSize = true;
            rbBussiness.BackColor = Color.Cyan;
            rbBussiness.Location = new Point(408, 167);
            rbBussiness.Name = "rbBussiness";
            rbBussiness.Size = new Size(142, 24);
            rbBussiness.TabIndex = 15;
            rbBussiness.TabStop = true;
            rbBussiness.Text = "Business Services";
            rbBussiness.UseVisualStyleBackColor = false;
            rbBussiness.CheckedChanged += rbBussiness_CheckedChanged;
            // 
            // rbProductions
            // 
            rbProductions.AutoSize = true;
            rbProductions.BackColor = Color.Cyan;
            rbProductions.Location = new Point(263, 167);
            rbProductions.Name = "rbProductions";
            rbProductions.Size = new Size(139, 24);
            rbProductions.TabIndex = 14;
            rbProductions.TabStop = true;
            rbProductions.Text = "Production Units";
            rbProductions.UseVisualStyleBackColor = false;
            rbProductions.CheckedChanged += rbProductions_CheckedChanged;
            // 
            // rbPublicServices
            // 
            rbPublicServices.AutoSize = true;
            rbPublicServices.BackColor = Color.Cyan;
            rbPublicServices.Location = new Point(130, 167);
            rbPublicServices.Name = "rbPublicServices";
            rbPublicServices.Size = new Size(127, 24);
            rbPublicServices.TabIndex = 13;
            rbPublicServices.TabStop = true;
            rbPublicServices.Text = "Public Services";
            rbPublicServices.UseVisualStyleBackColor = false;
            rbPublicServices.CheckedChanged += rbPublicServices_CheckedChanged;
            // 
            // rbHouseHold
            // 
            rbHouseHold.AutoSize = true;
            rbHouseHold.BackColor = Color.Cyan;
            rbHouseHold.Location = new Point(19, 167);
            rbHouseHold.Name = "rbHouseHold";
            rbHouseHold.Size = new Size(105, 24);
            rbHouseHold.TabIndex = 12;
            rbHouseHold.TabStop = true;
            rbHouseHold.Text = "HouseHold";
            rbHouseHold.UseVisualStyleBackColor = false;
            rbHouseHold.CheckedChanged += rbHouseHold_CheckedChanged;
            // 
            // txtThisMonth
            // 
            txtThisMonth.BackColor = SystemColors.Info;
            txtThisMonth.Location = new Point(102, 109);
            txtThisMonth.Name = "txtThisMonth";
            txtThisMonth.Size = new Size(280, 27);
            txtThisMonth.TabIndex = 10;
            // 
            // txtLastMonth
            // 
            txtLastMonth.BackColor = SystemColors.Info;
            txtLastMonth.Location = new Point(102, 63);
            txtLastMonth.Name = "txtLastMonth";
            txtLastMonth.Size = new Size(280, 27);
            txtLastMonth.TabIndex = 9;
            // 
            // lbThisMonth
            // 
            lbThisMonth.AutoSize = true;
            lbThisMonth.BackColor = SystemColors.ActiveCaptionText;
            lbThisMonth.ForeColor = SystemColors.ButtonHighlight;
            lbThisMonth.Location = new Point(19, 109);
            lbThisMonth.Name = "lbThisMonth";
            lbThisMonth.Size = new Size(82, 20);
            lbThisMonth.TabIndex = 7;
            lbThisMonth.Text = "This Month";
            lbThisMonth.Click += lbThisMonth_Click;
            // 
            // lbLastMonth
            // 
            lbLastMonth.AutoSize = true;
            lbLastMonth.BackColor = SystemColors.ActiveCaptionText;
            lbLastMonth.ForeColor = SystemColors.ButtonHighlight;
            lbLastMonth.Location = new Point(19, 63);
            lbLastMonth.Name = "lbLastMonth";
            lbLastMonth.Size = new Size(82, 20);
            lbLastMonth.TabIndex = 6;
            lbLastMonth.Text = "Last Month";
            // 
            // lsvBill
            // 
            lsvBill.Location = new Point(12, 300);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(1236, 138);
            lsvBill.TabIndex = 7;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.SelectedIndexChanged += lsvBill_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 450);
            Controls.Add(lsvBill);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogout;
        private GroupBox groupBox1;
        private ListView lsvBill;
        private Label lbThisMonth;
        private Label lbLastMonth;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private RadioButton rbBussiness;
        private RadioButton rbProductions;
        private RadioButton rbPublicServices;
        private RadioButton rbHouseHold;
        private TextBox txtThisMonth;
        private TextBox txtLastMonth;
        private TextBox txtName;
        private Label lbName;
        private Button btnPrintBill;
        private Label lbDiscription;
        private TextBox txtDiscription;
        private Label lbMember;
        private TextBox txtMember;
        private TextBox txtID;
        private Label lbID;
    }
}