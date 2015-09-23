using System;

namespace TrabalhoFinalASW.Providers
{
    public class RefreshToken
    {
        public RefreshToken()
        {
        }

        public string ClientId { get; set; }
        public DateTime ExpiresUtc { get; set; }
        public string Id { get; set; }
        public DateTime IssuedUtc { get; set; }
        public string ProtectedTicket { get; internal set; }
        public string Subject { get; set; }
    }
}