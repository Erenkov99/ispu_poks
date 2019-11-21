using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class RoomModel
    {
        public RoomModel() { }
        public RoomModel(Room r)
        {
            RoomNumber = r.RoomNumber;
            type = r.type;
            floor = r.floor;
        }
        public int RoomNumber { get; set; }
        public int type { get; set; }
        public int floor { get; set; }
    }
}
