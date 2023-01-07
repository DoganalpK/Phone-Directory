namespace Contact.Microservice.Models.Dtos
{
    public class KisilerIletisimBilgileriListDto
    {
        public Guid UUID { get; set; }
        public string BilgiIcerigi { get; set; }
        public string TelefonNumarasi { get; set; }
        public string EmailAdresi { get; set; }
        public string Konum { get; set; }
    }
}
