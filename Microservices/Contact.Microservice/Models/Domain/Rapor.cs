using Contact.Microservice.Models.Base;

namespace Contact.Microservice.Models.Domain
{
    public class Rapor : BaseEntity
    {
        public string Konum { get; set; }
        public int KisiSayi { get; set; }
        public int TelefonNumarasiSayi { get; set; }
        public int RaporDurumId { get; set; }
    }
}
