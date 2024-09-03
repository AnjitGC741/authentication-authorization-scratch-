namespace authentication_authorization_scratch_.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public EnumUserType Usertype { get; set; }
    }
    public enum EnumUserType
    {
        Admin = 1,
        Employee = 2
    }
}
