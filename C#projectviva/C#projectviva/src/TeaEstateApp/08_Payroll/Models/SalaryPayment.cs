using System;

namespace TeaEstate
{
    
    public class SalaryPayment
    {
        
        private int _paymentId;
        private int _workerId;
        private string _month;       
        private int _daysWorked;
        private decimal _dailyRate;
        private decimal _yieldBonus;
        private decimal _totalAmount;
        private DateTime _paidDate;

       
        public int PaymentId
        {
            get { return _paymentId; }
            set { _paymentId = value; }
        }

      
        public int WorkerId
        {
            get { return _workerId; }
            set { _workerId = value; }
        }

        
        public string Month
        {
            get { return _month; }
            set { _month = value; }
        }

       
        public int DaysWorked
        {
            get { return _daysWorked; }
            set { _daysWorked = value; }
        }

       
        public decimal DailyRate
        {
            get { return _dailyRate; }
            set { _dailyRate = value; }
        }

        
        public decimal YieldBonus
        {
            get { return _yieldBonus; }
            set { _yieldBonus = value; }
        }

        
        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }

        
        public DateTime PaidDate
        {
            get { return _paidDate; }
            set { _paidDate = value; }
        }

       
        public decimal CalculateTotal()
        {
            return _daysWorked * _dailyRate + _yieldBonus;
        }
    }
}
