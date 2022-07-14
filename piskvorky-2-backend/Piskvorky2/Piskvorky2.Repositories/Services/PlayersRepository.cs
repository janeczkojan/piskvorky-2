using MongoDB.Driver;
using Piskvorky2.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Piskvorky2.Domain;

namespace Piskvorky2.Repositories.Services
{
    public interface IPlayersRepository
    {
        Task<List<Player>> GetAll();
        Task<Player> Get(string id);
        Task Create(Player player);
        Task Update(Player player);
        Task Delete(string id);
    }

    internal class PlayersRepository : IPlayersRepository
    {
        private readonly IMongoCollection<Player> _playersCollection;

        public PlayersRepository(IOptions<DatabaseSettings> dbSettings)
        {
            var client = new MongoClient(dbSettings.Value.ConnectionString);

            var db = client.GetDatabase(dbSettings.Value.DatabaseName);

            _playersCollection = db.GetCollection<Player>(dbSettings.Value.PlayersCollectionName);
        }

        public async Task<List<Player>> GetAll() => await _playersCollection.Find(_ => true).ToListAsync();

        public async Task<Player> Get(string id) => await _playersCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task Create(Player player) => await _playersCollection.InsertOneAsync(player);

        public async Task Update(Player player) => await _playersCollection.ReplaceOneAsync(x => x.Id == player.Id, player);

        public async Task Delete(string id) => await _playersCollection.DeleteOneAsync(x => x.Id == id);
    }
}
