namespace TeaEstate
{
    // Member 01 — the base class for every person in the system.
    // OOP demonstrated here:
    //   * Abstraction  : 'abstract' class with an abstract method (cannot be created directly).
    //   * Encapsulation: private field '_name' exposed through a public property.
    // Member 02 inherits this with Worker / Supervisor / Manager.
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
