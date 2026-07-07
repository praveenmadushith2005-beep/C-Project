namespace TeaEstate
{
    // Member 01 — a login account (maps to the [User] table).
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }   // "Manager", "Supervisor" or "ProcessingOfficer"
    }
}
