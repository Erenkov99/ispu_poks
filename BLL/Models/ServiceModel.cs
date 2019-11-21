using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ServiceModel
    {
        public ServiceModel() { }
        public ServiceModel(Service s)
        {
            Code = s.Code;
            serviceName = s.serviceName;
            cost = s.cost;
        }
        public int Code { get; set; }
        public string serviceName { get; set; }
        public decimal cost { get; set; }
    }
}
