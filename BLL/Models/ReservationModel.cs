using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ReservationModel
    {
        public ReservationModel() { }
        public ReservationModel(Reservation r)
        {
            NumberR = r.NumberR;
            FIO = r.FIO;
            RoomNumber = r.RoomNumber;
            Rstart = r.Rstart;
            Rend = r.Rend;
        }
        public int NumberR { get; set; }
        public string FIO { get; set; }
        public int RoomNumber { get; set; }
        public DateTime Rstart { get; set; }
        public DateTime Rend { get; set; }
    }
}
