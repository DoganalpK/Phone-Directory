namespace Contact.Microservice.Models.Dtos
{
    public class IletisimBilgileriCreateDto
    {
        public string BilgiIcerigi { get; set; }
        public string TelefonNumarasi { get; set; }
        public string EmailAdresi { get; set; }
        public string Konum { get; set; }
        public Guid KisilerUUID { get; set; }
    }
}
