using BLL.Interfaces;
using BLL.Models;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DBDataOperations : IDbCrud
    {
        IDbRepos db;
        public DBDataOperations(IDbRepos repos)
        {
            db = repos;
        }

        public void CreateClient(ClientModel s)
        {
            db.Clients.Create(new DAL.Client()
            {
                ID = s.ID,
                FIO = s.FIO,
                seria = s.seria,
                number = s.number,
                adress = s.adress,
                date_bith = s.date_bith
            });
            Save();
        }

        public void DeleteClient(int id)
        {
            Client c = db.Clients.GetItem(id);
            if (c != null)
            {
                db.Clients.Delete(c.ID);
                Save();
            }
        }

        public List<ClientModel> GetAllClients()
        {
            return db.Clients.GetList().Select(i => new ClientModel(i)).ToList();
        }

        public ClientModel GetClient(int id)
        {
            return new ClientModel(db.Clients.GetItem(id));
        }

        public void UpdateClient(ClientModel s)
        {
            Client c = db.Clients.GetItem(s.ID);
            c.ID = s.ID;
            c.FIO = s.FIO;
            c.seria = s.seria;
            c.number = s.number;
            c.adress = s.adress;
            c.date_bith = s.date_bith;
        }

        public bool Save()
        {
            if (db.Save() > 0) return true;
            return false;
        }
    }
}
