namespace assm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPass.Text;


            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please Enter Your Name", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
            }
            else if (string.IsNullOrEmpty(pass))
            {

                MessageBox.Show("Please Enter Your Password", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Focus();
            }
            else
            {
                //check username and password
                if (name == "Anh Long" && pass == "123")
                {
                    Form2 caculator = new Form2();
                    caculator.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult check_confirm = MessageBox.Show("Do you want to exit?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check_confirm == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Continiue....");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

