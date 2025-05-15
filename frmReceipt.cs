using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_billing
{
    public partial class frmReceipt : Form
    {
        private int childFormNumber = 0;

        public frmReceipt()
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

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }//

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

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            tmrClock_Tick(null, null);
            lblSeller.Text ="فروشنده : "+ clsPublicVariable.Seller;
            int count = clsPublicVariable.Order.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    dgvReceipt.Rows.Add(new DataGridViewRow());
            //    dgvReceipt.Rows[i].Cells[0].Value = frmBilling.menu[clsPublicVariable.Order[i]].Service;
            //    dgvReceipt.Rows[i].Cells[1].Value = frmBilling.menu[clsPublicVariable.Order[i]].txtbox.Text;
            //    dgvReceipt.Rows[i].Cells[2].Value = frmBilling.menu[clsPublicVariable.Order[i]].Cost;
            //    int x = Convert.ToInt32(frmBilling.menu[clsPublicVariable.Order[i]].txtbox.Text);
            //    dgvReceipt.Rows[i].Cells[3].Value = x * frmBilling.menu[clsPublicVariable.Order[i]].Cost;
            //}
            //dgvReceipt.Rows[count].Cells[0].Value = "مجموع سفارش";
            //dgvReceipt.Rows[count].Cells[3].Value = clsPublicVariable.SumOfOrder.ToString();

            //dgvReceipt.Rows.Add(new DataGridViewRow());
            //dgvReceipt.Rows[count + 1].Cells[0].Value = "مالیات";
            //dgvReceipt.Rows[count + 1].Cells[3].Value = clsPublicVariable.Tax.ToString();

            //dgvReceipt.Rows.Add(new DataGridViewRow());
            //dgvReceipt.Rows[count + 2].Cells[0].Value = "خدمات";
            //dgvReceipt.Rows[count + 2].Cells[3].Value = clsPublicVariable.Service_Cost.ToString();

            //dgvReceipt.Rows.Add(new DataGridViewRow());
            //dgvReceipt.Rows[count + 3].Cells[0].Value = "کل";
            //dgvReceipt.Rows[count + 3].Cells[3].Value = clsPublicVariable.Total.ToString();




            for (int j = 0; j < count + 4; j++)
                dgvReceipt.Rows.Add(new DataGridViewRow());
            int i;
            for (i = 0; i < count; i++)
            {
                dgvReceipt.Rows[i].Cells[0].Value = frmBilling.menu[clsPublicVariable.Order[i]].Service;
                dgvReceipt.Rows[i].Cells[1].Value = frmBilling.menu[clsPublicVariable.Order[i]].txtbox.Text;
                dgvReceipt.Rows[i].Cells[2].Value = frmBilling.menu[clsPublicVariable.Order[i]].Cost;
                int x = Convert.ToInt32(frmBilling.menu[clsPublicVariable.Order[i]].txtbox.Text);
                dgvReceipt.Rows[i].Cells[3].Value = x * frmBilling.menu[clsPublicVariable.Order[i]].Cost;
            }
            dgvReceipt.Rows[i].Cells[0].Value = "مجموع سفارش";
            dgvReceipt.Rows[i].Cells[3].Value = clsPublicVariable.SumOfOrder.ToString();
            i++;
            dgvReceipt.Rows[i].Cells[0].Value = "مالیات";
            dgvReceipt.Rows[i].Cells[3].Value = clsPublicVariable.Tax.ToString();
            i++;
            dgvReceipt.Rows[i].Cells[0].Value = "خدمات";
            dgvReceipt.Rows[i].Cells[3].Value = clsPublicVariable.Service_Cost.ToString();
            i++;
            dgvReceipt.Rows[i].Cells[0].Value = "درصد تخفیف";
            dgvReceipt.Rows[i].Cells[2].Value = clsPublicVariable.Discount + " %";
            dgvReceipt.Rows[i].Cells[3].Value = clsPublicVariable.SumOfOrder + clsPublicVariable.Tax + clsPublicVariable.Service_Cost - clsPublicVariable.Total + "";
            i++;
            dgvReceipt.Rows[i].Cells[0].Value = "کل";
            dgvReceipt.Rows[i].Cells[3].Value = clsPublicVariable.Total.ToString();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            PersianCalendar persianCalendar = new PersianCalendar();
            lblDate.Text = persianCalendar.GetDayOfMonth(now) + " / " + persianCalendar.GetMonth(now) + " / " + persianCalendar.GetYear(now);
            lblTime.Text = now.Hour + " : " + now.Minute + " : " + now.Second;
        }
    }
}
