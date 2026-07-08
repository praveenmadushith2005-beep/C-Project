using System;

namespace TeaEstate
{

    public class YieldRecord
    {
        public int YieldID { get; set; }
        public int WorkerID { get; set; } 
        public int SectionID { get; set; }
        public decimal Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
