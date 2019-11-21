using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class TypesModel
    {
        public TypesModel() { }
        public TypesModel(Types t)
        {
            RoomType = t.RoomType;
            description = t.description;
            dayCost = t.dayCost;
        }
        public int RoomType { get; set; }
        public string description { get; set; }
        public decimal dayCost { get; set; }
    }
}
