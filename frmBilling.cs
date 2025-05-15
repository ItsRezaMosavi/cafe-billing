using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cafe_billing
{
    public partial class frmBilling : Form
    {
        private int childFormNumber = 0;

        public frmBilling()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public static List<clsPublicVariable> menu = new List<clsPublicVariable>();
        private void frmBilling_Load(object sender, EventArgs e)
        {
            tmrMain_Tick(null, null);
            clsPublicVariable cls0 = new clsPublicVariable();
            cls0.Service = "لاته";
            cls0.Cost = 75000;
            cls0.checkb = chbLate;
            cls0.label = lblLate_Cost;
            cls0.txtbox = txtLate_Count;
            menu.Add(cls0);
            clsPublicVariable cls1 = new clsPublicVariable();
            cls1.Service = "کاپوچینو";
            cls1.Cost = 68000;
            cls1.checkb = chbCappuccino;
            cls1.label = lblCappuccino_Cost;
            cls1.txtbox = txtCappuccino_Count;
            menu.Add(cls1);
            clsPublicVariable cls2 = new clsPublicVariable();
            cls2.Service = "اسپرسو";
            cls2.Cost = 40000;
            cls2.checkb = chbEspresso;
            cls2.label = lblEspresso_Cost;
            cls2.txtbox = txtEspresso_Count;
            menu.Add(cls2);
            clsPublicVariable cls3 = new clsPublicVariable();
            cls3.Service = "موکا";
            cls3.Cost = 95000;
            cls3.checkb = chbMocha;
            cls3.label = lblMocha_Cost;
            cls3.txtbox = txtMocha_Count;
            menu.Add(cls3);
            clsPublicVariable cls4 = new clsPublicVariable();
            cls4.Service = "چای";
            cls4.Cost = 15000;
            cls4.checkb = chbTea;
            cls4.label = lblTea_Cost;
            cls4.txtbox = txtTea_Count;
            menu.Add(cls4);
            clsPublicVariable cls5 = new clsPublicVariable();
            cls5.Service = "آیس کافی";
            cls5.Cost = 70000;
            cls5.checkb = chbIceCoffee;
            cls5.label = lblIceCoffee_Cost;
            cls5.txtbox = txtIceCoffee_Count;
            menu.Add(cls5);
            clsPublicVariable cls6 = new clsPublicVariable();
            cls6.Service = "شیر چای";
            cls6.Cost = 37000;
            cls6.checkb = chbMilkTea;
            cls6.label = lblMilkTea_Cost;
            cls6.txtbox = txtMilkTea_Count;
            menu.Add(cls6);
            clsPublicVariable cls7 = new clsPublicVariable();
            cls7.Service = "کارامل ماکیاتو";
            cls7.Cost = 119000;
            cls7.checkb = chbCaramelMacchiato;
            cls7.label = lblCaramelMacchiato_Cost;
            cls7.txtbox = txtCaramelMacchiato_Count;
            menu.Add(cls7);
            clsPublicVariable cls8 = new clsPublicVariable();
            cls8.Service = "کیک قهوه";
            cls8.Cost = 45000;
            cls8.checkb = chbCoffeeCake;
            cls8.label = lblCoffeeCake_Cost;
            cls8.txtbox = txtCoffeeCake_Count;
            menu.Add(cls8);
            clsPublicVariable cls9 = new clsPublicVariable();
            cls9.Service = "کیک وانیلی";
            cls9.Cost = 40000;
            cls9.checkb = chbVanillaCake;
            cls9.label = lblVanillaCake_Cost;
            cls9.txtbox = txtVanillaCake_Count;
            menu.Add(cls9);
            clsPublicVariable cls10 = new clsPublicVariable();
            cls10.Service = "کیک شکلاتی";
            cls10.Cost = 40000;
            cls10.checkb = chbChocolateCake;
            cls10.label = lblChocolateCake_Cost;
            cls10.txtbox = txtChocolateCake_Count;
            menu.Add(cls10);
            clsPublicVariable cls11 = new clsPublicVariable();
            cls11.Service = "کیک شکلاتی خیس";
            cls11.Cost = 57000;
            cls11.checkb = chbWetChocolateCake;
            cls11.label = lblWetChocolateCake_Cost;
            cls11.txtbox = txtWetChocolateCake_Count;
            menu.Add(cls11);
            clsPublicVariable cls12 = new clsPublicVariable();
            cls12.Service = "چیز کیک";
            cls12.Cost = 65000;
            cls12.checkb = chbCheeseCake;
            cls12.label = lblCheeseCake_Cost;
            cls12.txtbox = txtCheeseCake_Count;
            menu.Add(cls12);
            clsPublicVariable cls13 = new clsPublicVariable();
            cls13.Service = "کوکی شکلاتی";
            cls13.Cost = 60000;
            cls13.checkb = chbChocolateCookie;
            cls13.label = lblChocolateCookie_Cost;
            cls13.txtbox = txtChocolateCookie_Count;
            menu.Add(cls13);
            clsPublicVariable cls14 = new clsPublicVariable();
            cls14.Service = "کوکی اسمارتیزی";
            cls14.Cost = 60000;
            cls14.checkb = chbSmartiesCookie;
            cls14.label = lblSmartiesCookie_Cost;
            cls14.txtbox = txtSmartiesCookie_Count;
            menu.Add(cls14);
            clsPublicVariable cls15 = new clsPublicVariable();
            cls15.Service = "کوکی نارگیلی";
            cls15.Cost = 70000;
            cls15.checkb = chbCoconutCookie;
            cls15.label = lblCoconutCookie_Cost;
            cls15.txtbox = txtCoconutCookie_Count;
            menu.Add(cls15);

            for (int i = 0; i < 16; i++)
            {
                menu[i].label.Text = menu[i].Cost.ToString();
                menu[i].checkb.Text = menu[i].Service.ToString();
            }

            btnReCalculate_Click(null, null);
        }


        private void chb_check(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            int i = 0;
            for (i = 0; i < 16; i++)
            {
                if (cb == menu[i].checkb)
                {
                    break;
                }
            }

            if (cb.Checked == false)
            {
                menu[i].txtbox.Text = "0";
            }
            else if (menu[i].txtbox.Text == "0")
            {
                menu[i].txtbox.Text = "1";
            }
            btnReCalculate_Click(null, null);
        }

        private void countChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
            int i;
            for (i = 0; i < 16; i++)
            {
                if (txt == menu[i].txtbox)
                {
                    break;
                }
            }

            if (Convert.ToInt32(txt.Text) > 0)
                menu[i].checkb.Checked = true;
            else if (Convert.ToInt32(txt.Text) == 0)
                menu[i].checkb.Checked = false;
            else
            {
                menu[i].checkb.Checked = false;
                menu[i].txtbox.Text = "0";
            }
            btnReCalculate_Click(null, null);
        }

        private void CountValidating_KeyDown(object sender, KeyEventArgs e)
        {
            int i = 0;
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            for (i = 0; i < 16; i++)
            {
                if (textBox == menu[i].txtbox)
                {
                    break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    menu[i + 1].txtbox.Focus();
                }
                catch
                {
                    btnDiscount.Focus();
                }
            }
        }

        private void btnReCalculate_Click(object sender, EventArgs e)
        {
            clsCalculate.Receipt();
            txtCakesCost.Text = clsPublicVariable.CakesTotalCost.ToString();
            txtDrinksCost.Text = clsPublicVariable.DrinksTotalCost.ToString();
            txtSumOfOrder.Text = clsPublicVariable.SumOfOrder.ToString();
            txtTax.Text = clsPublicVariable.Tax.ToString();
            txtServices.Text = clsPublicVariable.Service_Cost.ToString();
            txtTotal.Text = clsPublicVariable.Total.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                menu[i].checkb.Checked = false;
            }
            clsPublicVariable.Discount = 0;
            txtDiscount.Text = "0";
            clsCalculate.Receipt();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblHour.Text = now.Hour + " : " + now.Minute + " : " + now.Second;
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    lblDate.Text = "یکشنبه";
                    break;
                case DayOfWeek.Monday:
                    lblDate.Text = "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    lblDate.Text = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    lblDate.Text = "چهارشنبه";
                    break;
                case DayOfWeek.Thursday:
                    lblDate.Text = "پنج شنبه";
                    break;
                case DayOfWeek.Friday:
                    lblDate.Text = "جمعه";
                    break;
                case DayOfWeek.Saturday:
                    lblDate.Text = "شنبه";
                    break;
            }

            PersianCalendar persianCalendar = new PersianCalendar();
            lblDate.Text += " " + persianCalendar.GetYear(now) + "/" + persianCalendar.GetMonth(now) + "/" + persianCalendar.GetDayOfMonth(now);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            clsPublicVariable.Discount = Convert.ToDouble(txtDiscount.Text);
            btnReCalculate_Click(null, null);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            frmReceipt frmReceipt = new frmReceipt();
            frmReceipt.ShowDialog();
        }

        private void frmBilling_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
