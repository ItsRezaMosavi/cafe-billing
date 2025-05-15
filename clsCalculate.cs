using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_billing
{
    public class clsCalculate
    {
        public static void Receipt()
        {
            double SumOfOrder = 0;
            double DrinksReceipt = 0;
            double Tax, Services;
            double Total = 0;
            clsPublicVariable.Order.Clear();
            for (int i = 0; i < 16; i++)
            {
                if (frmBilling.menu[i].checkb.Checked == true)
                {
                    int count = Convert.ToInt32(frmBilling.menu[i].txtbox.Text);
                    SumOfOrder += count * frmBilling.menu[i].Cost;
                    clsPublicVariable.Order.Add(i);
                }
                if (i == 7)
                    DrinksReceipt = SumOfOrder;
            }

            if (SumOfOrder <= 300000)
            {
                Services = SumOfOrder * 10 / 100;
                Tax = SumOfOrder * 10 / 100;
            }
            else
            {
                Services = SumOfOrder * 5 / 100;
                Tax = SumOfOrder * 7 / 100;
            }
            Total = SumOfOrder + Tax + Services;
            clsPublicVariable.SumOfOrder = SumOfOrder;
            clsPublicVariable.DrinksTotalCost = DrinksReceipt;
            clsPublicVariable.CakesTotalCost = SumOfOrder - DrinksReceipt;
            clsPublicVariable.Service_Cost = Services;
            clsPublicVariable.Tax = Tax;
            clsPublicVariable.Total = Total - (clsPublicVariable.Discount * Total / 100);
        }
    }
}
