using System.Security.AccessControl;
using api.models;
using System.Collections.Generic;
namespace api.interfaces
{
    public interface IStoreDataHandler
    {
         public List<Store> GetAllStores();
         public Store GetStore(int id);
         public void UpdateStore(Store value);
         public void CreateStore(Store value);
         public void DeleteStore(int id);
    }
}