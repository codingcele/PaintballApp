using PaintballApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballApp.Services
{
    public class ProblemService : IProblemService
    {
        private SQLiteAsyncConnection _dbConnection;
        public ProblemService()
        {
            SetUpDb();
        }
        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Problems.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Problem>();
            }
        }
        public Task<int> AddProblem(Problem problem)
        {
            return _dbConnection.InsertAsync(problem);
        }

        public Task<int> DeleteProblem(Problem problem)
        {
            return _dbConnection.DeleteAsync(problem);
        }

        public async Task<List<Problem>> GetProblemsList()
        {
            var problemsList = await _dbConnection.Table<Models.Problem>().ToListAsync();
            return problemsList;
        }

        public Task<int> UpdateProblem(Problem problem)
        {
            return _dbConnection.UpdateAsync(problem);
        }
    }
}
