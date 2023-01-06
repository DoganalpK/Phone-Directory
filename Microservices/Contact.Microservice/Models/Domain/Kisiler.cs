using Contact.Microservice.Models.Base;

namespace Contact.Microservice.Models.Domain
{
    public class Kisiler: BaseEntity
    {
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Firma { get; set; }
        public List<IletisimBilgileri>? IletisimBilgisi { get; set; }
    }
}