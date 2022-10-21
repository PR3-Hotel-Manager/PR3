using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Hotel_Management__Beta_1._0_
{
    public class Payment
    {
        // Attributes -------------------------
        public decimal price { get; set; }
        public string paymentType { get; set; }
        public string Time { get; set; }

        // Conctrustors -------------------------------
        public Payment(int price, string paymentType)
        {
            this.price = price;
            this.paymentType = paymentType;
            this.Time = transactionTime();
        }

        // Methods ------------------------------------
        public string transactionTime()
        {
            return DateTime.Now.ToString("mm/dd/yyyy h:mm:ss tt");
        }
    }
}
