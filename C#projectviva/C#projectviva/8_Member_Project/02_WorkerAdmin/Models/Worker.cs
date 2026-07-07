namespace TeaEstate
{
    // Member 02 — a field worker on the tea estate.
    // OOP: INHERITANCE  -> Worker extends the abstract Person (from Member 01).
    //      ENCAPSULATION -> data exposed through public properties.
    //      POLYMORPHISM  -> overrides GetRoleDescription() and GetSummary().
    public class Worker : Person
    {
        // The job title of the worker (e.g. "Plucker", "Pruner").
        public string Position { get; set; }

        // Abstraction satisfied: every Person must describe its role.
        public override string GetRoleDescription()
        {
            return "Field Worker";
        }

        // Polymorphism: a worker summarises itself with its name and position.
        public override string GetSummary()
        {
            return "Worker: " + Name + " - " + Position;
        }
    }
}
