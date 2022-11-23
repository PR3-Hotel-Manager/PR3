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
        public double Price { get; set; }
        public string PaymentType { get; set; }
        public string Time { get; set; }

        // Conctrustors -------------------------------
        public Payment()
        {
            this.Price = 101;
            this.PaymentType = "";
            this.Time = transactionTime();
        }

        public Payment(string paymentType)
        {
            this.Price = 101;
            this.PaymentType = paymentType;
            this.Time = transactionTime();
        }
        public Payment(double price, string paymentType)
        {
            this.Price = price;
            this.PaymentType = paymentType;
            this.Time = transactionTime();
        }

        // Methods ------------------------------------
        
        // This method returns the current time for transaction details
        public string transactionTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
        }

        public decimal CalculatePrice(decimal bedConfigs, decimal stayLength)
        {
            int b = Convert.ToInt32(bedConfigs);
            int s = Convert.ToInt32(stayLength);
            return Convert.ToDecimal((100 + Math.Pow(b * s, 2)));
        }
    }
}
