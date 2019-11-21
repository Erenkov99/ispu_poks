using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDbCrud
    {
        List<ClientModel> GetAllClients();
        ClientModel GetClient(int id);
        void CreateClient(ClientModel s);
        void UpdateClient(ClientModel s);
        void DeleteClient(int id);
    }
}
