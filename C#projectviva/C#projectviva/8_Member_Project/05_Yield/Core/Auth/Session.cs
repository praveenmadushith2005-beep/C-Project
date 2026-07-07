namespace TeaEstate
{
	// Member 01 — keeps the currently logged-in user so any form can check the role
	// (e.g. to decide which buttons or actions are allowed).
	public static class Session
	{
		public static User CurrentUser;
	}
}
