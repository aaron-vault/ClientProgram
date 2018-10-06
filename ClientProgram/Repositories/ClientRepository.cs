using ClientProgramLib.Data;
using ClientProgramLib.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProgram.Repositories
{
    public class ClientRepository : ICrudRepository<Client>
    {
        public IEnumerable<Client> GetClients()
        {
            using (var db = new ClientContext())
            {
                return db.Clients.ToList();
            }
        }

        public async Task<Client> GetClientById(int id)
        {
            using (var db = new ClientContext())
            {
                return await db.Clients.FindAsync(id);
            }
        }

        public async Task<Client> Create(Client client)
        {
            using (var db = new ClientContext())
            {
                db.Clients.Add(client);
                await db.SaveChangesAsync();

                return client;
            }
        }

        public async Task<Client> Read(int id)
        {
            using (var db = new ClientContext())
            {
                Client client = await db.Clients.FindAsync(id);
                return client;
            }
        }

        public async Task<Client> Update(Client client)
        {
            using (var db = new ClientContext())
            {
                db.Entry(client).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return client;
            }
        }

        public async Task<Client> Delete(int id)
        {
            using (var db = new ClientContext())
            {
                Client client = await db.Clients.FindAsync(id);
                db.Clients.Remove(client);
                await db.SaveChangesAsync();
                return client;
            }
        }
    }
}
