namespace TeaEstate
{
    // Member 02 — a supervisor is a special kind of Worker.
    // OOP: INHERITANCE chain Supervisor : Worker : Person.
    //      POLYMORPHISM -> only changes the role description; reuses Worker's GetSummary().
    public class Supervisor : Worker
    {
        // Override only the role description; everything else comes from Worker.
        public override string GetRoleDescription()
        {
            return "Field Supervisor";
        }
    }
}
