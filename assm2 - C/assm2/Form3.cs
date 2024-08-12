using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static assm2.Form2;

namespace assm2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string typescustomer { get; set; }
        public string LMW { get; set; }
        public string TMW { get; set; }
        public string WaterUsed { get; set; }
        public string price { get; set; }
        public string environmentFee { get; set; }
        public string VAT { get; set; }
        public string TotalBill { get; set; }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            lbId.Text = $"{ID}";
            lbName.Text = $"{Name}";
            lbTypesCustomer.Text = $"{typescustomer}";
            lbLastMonth.Text = $"{LMW:0.##} m³";
            lbThisMonth.Text = $"{TMW:0.##} m³"; 
            lbWaterUsed.Text = $"{WaterUsed:0.##} m³";
            lbPrice.Text = $"{price:0.##} VND";
            lbEnvironmetFee.Text = $"{environmentFee:0.##} VND";
            lbVAT.Text = $"{VAT:0.##} VND";
            lbTotalBill.Text = $"{TotalBill:0.#} VND"; 

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure want to the Login screen?", "Any unsaved changes will be lost.",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure want to the Caculator screen?", "Any unsaved changes will be lost.",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form2 caculator = new Form2();
                caculator.Show();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            pbQR.Visible = true;
        }
    }
}
