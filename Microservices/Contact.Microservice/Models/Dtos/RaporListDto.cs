namespace Contact.Microservice.Models.Dtos
{
    public class RaporListDto
    {
        public Guid UUID { get; set; }
        public string Konum { get; set; }
        public int KisiSayi { get; set; }
        public int TelefonNumarasiSayi { get; set; }
        public int RaporDurumId { get; set; }
    }
}
