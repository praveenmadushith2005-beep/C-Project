namespace TeaEstate
{
    public abstract class Person
    {
        private string _name;   // encapsulation: hidden backing field

        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address { get; set; }
        public string ContactNo { get; set; }

        // Abstraction: each kind of person MUST describe its own role.
        public abstract string GetRoleDescription();

        // Polymorphism: subclasses can override how they summarise themselves.
        public virtual string GetSummary()
        {
            return Name + " (" + ContactNo + ")";
        }
    }
}
