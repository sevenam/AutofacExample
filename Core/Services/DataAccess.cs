using Core.Interfaces;
using System;

namespace Core.Services
{
    public class DataAccess : IDataAccess
    {
        public string GetData() {
            var data = "This is all the data.";
            return data;
        }

        public bool StoreData(string data)
        {
            Console.WriteLine($"Data stored: {data}");
            return true;
        }
    }
}
