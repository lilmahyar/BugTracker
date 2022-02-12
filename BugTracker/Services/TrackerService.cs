using BugTracker.Commands;
using BugTracker.Mapper;
using BugTracker.Models;
using BugTracker.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
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
        public async Task<Bug> AddNewBugAsync(AddNewBugCommand command)
        {
            var bug = command.ToModel();
            await  _bug.InsertOneAsync(bug);
            return bug; 
        }

        public async Task<List<Bug>> GetAllAsync()
        {
           return await _bug.Find(c => true).ToListAsync();
        }

        public async Task<Bug> GetByIdAsync(string id)
        {
            return await _bug.Find<Bug>(c => c.Id == id).FirstOrDefaultAsync();
        }
    }
}
