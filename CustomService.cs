using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp8
{
    public class CustomService : ICustomService
    {
        private readonly IDataService dataService;
        public CustomService(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public string SomeLogic()
        {
            return dataService.GetUserName("userid");
        }
    }
}
