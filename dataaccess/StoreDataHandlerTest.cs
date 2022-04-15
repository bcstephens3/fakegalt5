using System.Collections.Generic;
using api.interfaces;
using api.models;
namespace api.dataaccess
{
    public class StoreDataHandlerTest : IStoreDataHandler
    {
        public List<Store> GetAllStores()
        {
            List<Store> myStores = new List<Store>();
            myStores.Add(new Store()
            {   id=1,
                addressLineOne="123 Dirt Rd",
                addressLineTwo="",
                city = "Clanton",
                state="Alabama",
                zip=35405
            });
            myStores.Add(new Store()
            {   id=1,
                addressLineOne="124 Paved Rd",
                addressLineTwo="",
                city = "Colleyville",
                state="Texas",
                zip=35045
            });
            myStores.Add(new Store()
            {   id=1,
                addressLineOne="1267 Bumpy Rd",
                addressLineTwo="box 1313",
                city = "Tuscaloosa",
                state="Alabama",
                zip=35404
            });
            return myStores;

        }
        public Store GetStore(int id)
        {
            return new Store();
        }
        public void UpdateStore(Store value)
        {
            throw new System.NotImplementedException();
        }
        
        public void CreateStore(Store value)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteStore(int id)
        {
            throw new System.NotImplementedException();
        }

        

        

        
    }
}