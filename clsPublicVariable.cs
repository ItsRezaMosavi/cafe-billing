using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace cafe_billing
{
    public class clsPublicVariable
    {
        public static Dictionary<string, string> Username_Password = new Dictionary<string, string>();
        public static Dictionary<int, int> Drink_cost = new Dictionary<int, int>();
        public static Dictionary<int, int> Cake_cost = new Dictionary<int, int>();
        public static List<int> Order = new List<int>();

        public static string Seller = ""; 
        public static double CakesTotalCost = 0;
        public static double DrinksTotalCost = 0;
        public static double SumOfOrder = 0;
        public static double Tax = 0;
        public static double Service_Cost = 0;
        public static double Total = 0;
        public static double Discount = 0;



        public string Service { get; set; }
        public int Cost { get; set; }
        public CheckBox checkb { get; set; }
        public Label label { get; set; }
        public TextBox txtbox { get; set; }

    }
}
