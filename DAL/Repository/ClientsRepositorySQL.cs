using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Repository
{
    public class ClientsRepositorySQL: IRepository<Client>
    {
        private HotelModel db;
        public ClientsRepositorySQL(HotelModel dbcontext)
        {
            this.db = dbcontext;
        }

        public void Create(Client item)
        {
            db.Client.Add(item);
        }

        public void Delete(int id)
        {
            Client client = db.Client.Find(id);
            if (client != null)
                db.Client.Remove(client);
        }

        public Client GetItem(int id)
        {
            return db.Client.Find(id);
        }

        public List<Client> GetList()
        {
            return db.Client.ToList();
        }

        public void Update(Client item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
