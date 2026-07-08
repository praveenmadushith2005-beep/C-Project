using System;

namespace TeaEstate
{
   
    public class ProcessingRecord
    {
        public int ProcessID { get; set; }              
        public int YieldID { get; set; }               
        public DateTime ProcessingDate { get; set; }    
        public decimal ProcessedQuantity { get; set; } 
    }
}
