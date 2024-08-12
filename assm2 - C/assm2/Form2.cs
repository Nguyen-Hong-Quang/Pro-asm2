using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static assm2.Form3;

namespace assm2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lsvBill.GridLines = true;
            lsvBill.FullRowSelect = true;
            //Change view mode to display data on lsv
            lsvBill.View = View.Details;

            lsvBill.Columns.Add("ID", 100);
            lsvBill.Columns.Add("Name", 150);
            lsvBill.Columns.Add("Last Month", 100);
            lsvBill.Columns.Add("This Month", 100);
            lsvBill.Columns.Add("Types of customer", 150);
            lsvBill.Columns.Add("Water Used", 100);
            lsvBill.Columns.Add("Cost", 150);
            lsvBill.Columns.Add("Environment Fee", 150);
            lsvBill.Columns.Add("VAT Fee", 150);
            lsvBill.Columns.Add("Total Bill", 150);
        }

        private void lbThisMonth_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Initialize variables to get values ​​in form
            string ID = default;
            string Name = default;

            //check not null ID
            if (String.IsNullOrEmpty(txtID.Text)) 
            { 
                MessageBox.Show("Please enter your ID", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ID = txtID.Text;
            }
            //check not null Name
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter your Name", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Name = txtName.Text;
            }

            double LMW = 0;
            double TMW = 0;

            //Require user to re-enter if not a number
            bool isValidInput = false;
            while (!isValidInput)
            {
                if (!double.TryParse(txtLastMonth.Text, out LMW) || LMW < 0)
                {
                    MessageBox.Show("Invalid input. Please input agian.");
                    txtLastMonth.Focus();// Move the mouse pointer to the last month's water data entry cell
                    return;//Stop processing if invalid
                }
                else if (!double.TryParse(txtThisMonth.Text, out TMW) || TMW < 0)
                {
                    MessageBox.Show("Invalid input. Please input agian.");
                    txtThisMonth.Focus();// Move the mouse cursor to the data entry cell for this month
                    return;//Stop processing if invalid
                }
                else
                {
                    isValidInput = true; //Correctly mark data
                }
            }

            //Check the water level of last month must be less than or equal to the water level of this month
            if (LMW >= TMW)
            {
                MessageBox.Show("Error: Current water meter reading must be greater than or equal to the previous reading. Please enter again.");
                return;
            }


            string typescustomer = null;
            if (rbHouseHold.Checked)
            {
                typescustomer = "HouseHold";
            }
            else if (rbPublicServices.Checked)
            {
                typescustomer = "Public Services";
            }
            else if (rbProductions.Checked)
            {
                typescustomer = "Productions Units";
            }
            else if (rbBussiness.Checked)
            {
                typescustomer = "Business Services";
            }
            else
            {
                MessageBox.Show("Please enter your Types of customer", "Notice",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Calculate water bill by customer type
            double WaterUsed = TMW - LMW;

            double house_hold_1 = 5.973;
            double house_hold_2 = 7.052;
            double house_hold_3 = 8.6999;
            double house_hold_4 = 15.929;
            double price_agenices = 9.955;
            double price_production = 11.615;
            double price_business = 22.868;

            double price = 0;
            double environmentFee, VAT, TotalBill;
            switch (typescustomer)
            {
                case "HouseHold":
                    if (WaterUsed <= 10)
                    {
                        price = WaterUsed * house_hold_1;
                    }
                    else if (WaterUsed <= 20)
                    {
                        price = (10 * house_hold_1) + (WaterUsed - 10) * house_hold_2;
                    }
                    else if (WaterUsed <= 30)
                    {
                        price = (10 * house_hold_1) + (10 * house_hold_2) + (WaterUsed - 20) * house_hold_3;
                    }
                    else
                    {
                        price = (10 * house_hold_1) + (10 * house_hold_2) + (10 * house_hold_3) + (WaterUsed - 30) * house_hold_4;
                    }
                    break;
                case "Public Services":
                    price = WaterUsed * price_agenices;
                    break;

                case "Productions Units":
                    price = WaterUsed * price_production;
                    break;

                case "Business Services":
                    price = WaterUsed * price_business;
                    break;
            }
            
            price = Math.Round(price, 3);
            environmentFee = Math.Round(price * 0.1, 3);
            VAT = Math.Round((price + environmentFee) * 0.1, 3);
            TotalBill = Math.Round(price + environmentFee + VAT, 3);

            //Declare new object
            ListViewItem item = new ListViewItem();

            //Assign values ​​in form to item
            item.Text = ID;
            item.SubItems.Add(Name);
            item.SubItems.Add(LMW.ToString());
            item.SubItems.Add(TMW.ToString());
            item.SubItems.Add(typescustomer);
            item.SubItems.Add(WaterUsed.ToString());
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(environmentFee.ToString());
            item.SubItems.Add(VAT.ToString());
            item.SubItems.Add(TotalBill.ToString());
            //Push data into lsvBill
            lsvBill.Items.Add(item);
        }
   


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvBill.SelectedItems[0];
                item.SubItems.Clear();

                //Initialize variables to get values ​​in form
                string ID = default;
                string Name = default;

                //check not null ID
                if (String.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Please enter your ID", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ID = txtID.Text;
                }
                //check not null Name
                if (String.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please enter your Name", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Name = txtName.Text;
                }

                double LMW = 0;
                double TMW = 0;

                //Require user to re-enter if not a number
                bool isValidInput = false;
                while (!isValidInput)
                {
                    if (!double.TryParse(txtLastMonth.Text, out LMW) || LMW < 0)
                    {
                        MessageBox.Show("Invalid input. Please re-enter last month's water index.");
                        txtLastMonth.Focus();// Move the mouse pointer to the last month's water data entry cell
                        return;//Stop processing if invalid
                    }
                    else if (!double.TryParse(txtThisMonth.Text, out TMW) || TMW < 0)
                    {
                        MessageBox.Show("Invalid input. Please re-enter this month's water index..");
                        txtThisMonth.Focus();//Move the mouse pointer to the this month's water data entry cell
                        return;//Stop processing if invalid
                    }
                    else
                    {
                        isValidInput = true; //Correctly mark data
                    }
                }
                //Check the water level of last month must be less than or equal to the water level of this month
                if (LMW >= TMW)
                {
                    MessageBox.Show("Error: Current water meter reading must be greater than or equal to the previous reading. Please enter again.");
                    return;
                }

                string typescustomer = null;
                if (rbHouseHold.Checked)
                {
                    typescustomer = "HouseHold";
                }
                else if (rbPublicServices.Checked)
                {
                    typescustomer = "Public Services";
                }
                else if (rbProductions.Checked)
                {
                    typescustomer = "Productions Units";
                }
                else if (rbBussiness.Checked)
                {
                    typescustomer = "Business Services";
                }
                else
                {
                    MessageBox.Show("Please enter your types of customer", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Calculate water bill by customer type
                double WaterUsed = TMW - LMW;

                double house_hold_1 = 5.973;
                double house_hold_2 = 7.052;
                double house_hold_3 = 8.6999;
                double house_hold_4 = 15.929;
                double price_agenices = 9.955;
                double price_production = 11.615;
                double price_business = 22.868;

                double price = 0;
                double environmentFee, VAT, TotalBill;

                switch (typescustomer)
                {
                    case "HouseHold":
                        if (WaterUsed <= 10)
                        {
                            price = WaterUsed * house_hold_1;
                        }
                        else if (WaterUsed <= 20)
                        {
                            price = (10 * house_hold_1) + (WaterUsed - 10) * house_hold_2;
                        }
                        else if (WaterUsed <= 30)
                        {
                            price = (10 * house_hold_1) + (10 * house_hold_2) + (WaterUsed - 20) * house_hold_3;
                        }
                        else
                        {
                            price = (10 * house_hold_1) + (10 * house_hold_2) + (10 * house_hold_3) + (WaterUsed - 30) * house_hold_4;
                        }
                        break;

                    case "Public Services":
                        price = WaterUsed * price_agenices;
                        break;

                    case "Productions Units":
                        price = WaterUsed * price_production;
                        break;

                    case "Business Services":
                        price = WaterUsed * price_business;
                        break;

                }

                
                price = Math.Round(price, 3);
                environmentFee = Math.Round (price * 0.1, 3);
                VAT = Math.Round((price + environmentFee) * 0.1, 3);
                TotalBill = Math.Round(price + environmentFee + VAT, 3);

                //Assign values ​​in form to item
                item.Text = ID;
                item.SubItems.Add(Name);
                item.SubItems.Add(LMW.ToString());
                item.SubItems.Add(TMW.ToString());
                item.SubItems.Add(typescustomer);
                item.SubItems.Add(WaterUsed.ToString());
                item.SubItems.Add(price.ToString());
                item.SubItems.Add(environmentFee.ToString());
                item.SubItems.Add(VAT.ToString());
                item.SubItems.Add(TotalBill.ToString());

                //Delete data on old form
                txtID.Text = ID;
                txtName.Text = Name;
                txtLastMonth.Text = LMW.ToString();
                txtThisMonth.Text = TMW.ToString();
                rbHouseHold.Checked = typescustomer == "HouseHold";
                rbPublicServices.Checked = typescustomer == "Public Services";
                rbProductions.Checked = typescustomer == "Production Units";
                rbBussiness.Checked = typescustomer == "Business Services";
            }
            else
            {
                MessageBox.Show("Please select an item to edit", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                lsvBill.Items.Remove(lsvBill.SelectedItems[0]);
            }
        }


        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListView
            if (lsvBill.SelectedItems.Count > 0)
            {
                // Get the first selected item from the ListView
                ListViewItem item = lsvBill.SelectedItems[0];

                // Create a new instance of Form3
                Form3 frm_bill = new Form3();

                // Set Form3 properties from item information in ListView
                frm_bill.ID = item.Text;
                frm_bill.Name = item.SubItems[1].Text;
                frm_bill.LMW = item.SubItems[2].Text;
                frm_bill.TMW = item.SubItems[3].Text;
                frm_bill.typescustomer = item.SubItems[4].Text;
                frm_bill.WaterUsed = item.SubItems[5].Text;
                frm_bill.price = item.SubItems[6].Text;
                frm_bill.environmentFee = item.SubItems[7].Text;
                frm_bill.VAT = item.SubItems[8].Text;
                frm_bill.TotalBill = item.SubItems[9].Text;

                frm_bill.Show();
                this.Hide();
            }
        }

        

        private void rbHouseHold_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscription.Text =
                "------------------Price Water------------------\r\n" +
                "To 10 m3/people/month           |5.973 VND/m3\r\n" +
                "From 10-20 m3/people/month |7.052 VND/m3\r\n" +
                "From 20-30 m3/people/month |8.699 VND/m3\r\n" +
                "Over 30 m3/people/month       |15.929 VND/m3\r\n" +
                "Enviroment protection fees (10%)\r\n"+
                "VAT fees (10%)\r\n";

            lbMember.Visible = true;
            txtMember.Visible = true;
        }

        private void rbPublicServices_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscription.Text =
                "------------------Price Water------------------\r\n" +
                "Price:                                 9.955 VND/m3\r\n" +
                "Enviroment protection fees (10%)\r\n" +
                "VAT fees (10%)\r\n" ;
        }

        private void rbProductions_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscription.Text =
               "------------------Price Water------------------\r\n" +
               "Price:                                 11.615  VND/m3\r\n"+
               "Enviroment protection fees (10%)\r\n" +
                "VAT fees (10%)\r\n";
        }

        private void rbBussiness_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscription.Text =
               "------------------Price Water------------------\r\n" +
               "Price:                                 22.068  VND/m3\r\n"+
               "Enviroment protection fees (10%)\r\n" +
                "VAT fees (10%)\r\n";
        }
    }
}
