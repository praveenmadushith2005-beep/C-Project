using System;

namespace TeaEstate
{
    // Member 05 — model for one tea-leaf yield entry (how much a worker picked
    // from a given section on a given day).
    // OOP: Encapsulation — data is exposed through public properties.
    // Maps to the YieldRecord table (YieldID PK, WorkerID FK, SectionID FK, Quantity DECIMAL, [Date]).
    public class YieldRecord
    {
        public int YieldID { get; set; }      // primary key (auto-number in the DB)
        public int WorkerID { get; set; }     // which worker picked the leaves
        public int SectionID { get; set; }    // which estate section it came from
        public decimal Quantity { get; set; }  // amount picked (kg)
        public DateTime Date { get; set; }      // the day it was recorded
    }
}
