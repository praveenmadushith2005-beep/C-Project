using System.Data;

namespace TeaEstate
{
    
    public interface IDataManager
    {
        DataTable GetAll();       
        void DeleteById(int id);   
    }
}
