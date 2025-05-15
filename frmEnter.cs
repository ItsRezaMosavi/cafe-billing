using System.Diagnostics;

namespace cafe_billing
{
    public partial class frmEnter : Form
    {
        public frmEnter()
        {
            InitializeComponent();
        }

        private void frmEnter_Load(object sender, EventArgs e)
        {
            clsPublicVariable.Username_Password.Add("reza", "reza123");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (clsPublicVariable.Username_Password.Any(u => u.Key == txtUserName.Text))
            {
                if (txtPassword.Text == clsPublicVariable.Username_Password[txtUserName.Text])
                {
                    clsPublicVariable.Seller = txtUserName.Text;
                    this.Hide();
                    frmBilling frmBilling = new frmBilling();
                    frmBilling.Show();
                }
                else
                    MessageBox.Show("اطلاعات ورود نادرست می باشند !");
            }
            else
                MessageBox.Show("اطلاعات ورود نادرست می باشند !");
        }
    }
}
