using Core.Interfaces;

namespace Core.Services
{
    public class DataModifier : IDataModifier
    {
        private readonly IDataAccess dataAccess;

        public DataModifier(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public string GetData() => dataAccess.GetData();

        public void ImproveData(string improvements)
        {
            var improvedData = $"{GetData()}{improvements}";
            dataAccess.StoreData(improvedData);
        }

    }
}
