using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MonkeyFinder
{
    public class LoginDatabase
    {
        readonly SQLiteAsyncConnection database;

        public LoginDatabase(string dbpath)
        {
            database = new SQLiteAsyncConnection(dbpath);
            database.CreateTableAsync<LoginModel>().Wait();
        }

        public Task<LoginModel> GetLoginDataAsync(string username)
        {
            return database.Table<LoginModel>().Where(i=> i.UserName == username).FirstOrDefaultAsync();
        }

        public Task<int> SaveLoginDataAsync(LoginModel logindata)
        {
            return database.InsertAsync(logindata);
        }

        public Task<int> DeleteLoginDataAsync()
        {
            return database.DeleteAllAsync<LoginModel>();
        }
    }
}
