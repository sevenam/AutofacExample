namespace Core.Interfaces
{
    public interface IDataAccess
    {
        bool StoreData(string data);
        string GetData();
    }
}
