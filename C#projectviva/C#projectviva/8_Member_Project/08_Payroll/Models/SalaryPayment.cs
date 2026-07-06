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

       
