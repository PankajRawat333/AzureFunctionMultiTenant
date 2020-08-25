using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp8
{
    public class DataService : IDataService
    {
        private readonly string databaseName;
        public DataService(string dbName)
        {
            this.databaseName = dbName;
        }

        public string GetUserName(string userId)
        {
            return this.databaseName;
        }
    }
}
