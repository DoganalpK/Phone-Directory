namespace Contact.Microservice.Models.Dtos
{
    public class KisilerIletisimBilgileriListDto
    {
        public Guid UUID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Firma { get; set; }
        public List<IletisimBilgileriListDto>? IletisimBilgileri { get; set; }
    }
}
