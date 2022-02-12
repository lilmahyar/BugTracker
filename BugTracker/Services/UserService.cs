using BugTracker.Models;
using BugTracker.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace BugTracker.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _user;
        private readonly DeveloperDatabaseConfiguration _settings;
        public UserService(IOptions<DeveloperDatabaseConfiguration> settings)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.DatabaseName);
            _user = database.GetCollection<User>(_settings.CustomerCollectionName);
        }
        public async Task<User> AddUser(User user)
        {
            await  _user.InsertOneAsync(user);
            return user; 
        }
    }
}
