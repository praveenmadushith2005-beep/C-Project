namespace TeaEstate
{
    
    public class Worker : Person
    {
        
        public string Position { get; set; }

        
        public override string GetRoleDescription()
        {
            return "Field Worker";
        }

        
        public override string GetSummary()
        {
            return "Worker: " + Name + " - " + Position;
        }
    }
}
