namespace authentication_authorization_scratch_.Models
{
    public class LoggedInUserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public EnumUserType UserType { get; set; }
        public bool IsSuperAdmin { get; set; }

    }
}
