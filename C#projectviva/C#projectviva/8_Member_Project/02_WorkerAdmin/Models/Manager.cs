namespace TeaEstate
{
    // Member 02 — a manager is also a kind of Worker.
    // OOP: INHERITANCE chain Manager : Worker : Person.
    //      POLYMORPHISM -> changes only the role description.
    public class Manager : Worker
    {
        // Override only the role description; reuses Worker's GetSummary().
        public override string GetRoleDescription()
        {
            return "Estate Manager";
        }
    }
}
