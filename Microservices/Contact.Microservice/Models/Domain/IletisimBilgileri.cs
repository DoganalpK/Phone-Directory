using Contact.Microservice.Models.Base;

namespace Contact.Microservice.Models.Domain
{
    public class IletisimBilgileri : BaseEntity
    {
        public string? BilgiIcerigi { get; set; }
        public string? TelefonNumarasi { get; set; }
        public string? EmailAdresi { get; set; }
        public string? Konum { get; set; }
        public Guid KisilerUUID { get; set; }
        public Kisiler Kisiler { get; set; }
    }
}