using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class LivingModel
    {
        public LivingModel() { }

        public LivingModel(Living l)
        {
            NumberL = l.NumberL;
            ID = l.ID;
            Room_number = l.Room_number;
            Zaselenie = l.Zaselenie;
            Vyselenie = l.Vyselenie;
            SumToPay = l.SumToPay;
            Paid = l.Paid;
        }

        public int NumberL { get; set; }
        public int ID { get; set; }
        public int Room_number { get; set; }
        public DateTime Zaselenie { get; set; }
        public DateTime Vyselenie { get; set; }
        public decimal SumToPay { get; set; }
        public decimal Paid { get; set; }
    }
}
