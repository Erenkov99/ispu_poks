using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ServiceCustomersModel
    {
        public ServiceCustomersModel() { }
        public ServiceCustomersModel(ServiceCustomers sc)
        {
            NumberSC = sc.NumberSC;
            ID = sc.ID;
            Scode = sc.Scode;
            PaymentFact = sc.PaymentFact;
            ServTime = sc.ServTime;
        }
        public int NumberSC { get; set; }
        public int ID { get; set; }
        public int Scode { get; set; }
        public int PaymentFact { get; set; }
        public DateTime ServTime { get; set; }
    }
}
