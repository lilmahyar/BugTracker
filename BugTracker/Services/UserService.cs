using BugTracker.Models;
using BugTracker.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace BugTracker.Services
{
    public class TrackerService
    {
        private readonly IMongoCollection<Bug> _bug;
        private readonly DeveloperDatabaseConfiguration _settings;
        public TrackerService(IOptions<DeveloperDatabaseConfiguration> settings)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.DatabaseName);
            _bug = database.GetCollection<Bug>(_settings.CustomerCollectionName);
        }
        public async Task<Bug> AddNewBugAsync(Bug bug)
        {
            await  _bug.InsertOneAsync(bug);
            return bug; 
        }
    }
}
