namespace E_Tickets.Data
{
    internal class ApplicationUser
    {
        public ApplicationUser()
        {
        }

        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}