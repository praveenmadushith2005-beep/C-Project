using System.Data;

namespace TeaEstate
{
    // Member 01 — OOP: interface. The shared "contract" every data repository follows
    // (WorkerRepository, AttendanceRepository, SectionRepository, etc. all implement this).
    public interface IDataManager
    {
        DataTable GetAll();        // return all rows for a grid
        void DeleteById(int id);   // delete one row by its primary key
    }
}
