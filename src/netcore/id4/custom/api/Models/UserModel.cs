namespace api.Models
{
    public class UserModel
    {
        public string userName { get; set; }
        public string password { get; set; }
    }

    public class UserToken
    {
        public string accessToken { get; set; }
        public int expiresIn { get; set; }
        public string tokenType { get; set; }
    }
}