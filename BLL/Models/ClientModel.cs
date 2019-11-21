using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ClientModel
    {
        public ClientModel() { }

        public ClientModel(Client c)
        {
            ID = c.ID;
            FIO = c.FIO;
            seria = c.seria;
            number = c.number;
            adress = c.adress;
            date_bith = c.date_bith;
        }
        public int ID { get; set; }
        public string FIO { get; set; }
        public int seria { get; set; }
        public int number { get; set; }
        public string adress { get; set; }
        public DateTime date_bith { get; set; }
    }
}
