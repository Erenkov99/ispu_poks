using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class DbReposSQL : IDbRepos
    {
        private HotelModel db;
        private ClientsRepositorySQL clientsRepository;
        public DbReposSQL()
        {
            db = new HotelModel();
        }

        public IRepository<Client> Clients
        {
            get
            {
                if (clientsRepository == null)
                    clientsRepository = new ClientsRepositorySQL(db);
                return clientsRepository;
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
