
namespace CoreDominationBootCamp.Models.Auth
{
    public class TokenModel
    {
        public string accessToken { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}