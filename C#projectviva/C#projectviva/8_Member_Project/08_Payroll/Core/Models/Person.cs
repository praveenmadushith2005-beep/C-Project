namespace TeaEstate
{
   
    public abstract class Person
    {
        private string _name;  

        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address { get; set; }
        public string ContactNo { get; set; }

        
        public abstract string GetRoleDescription();

        
        public virtual string GetSummary()
        {
            return Name + " (" + ContactNo + ")";
        }
    }
}

