namespace Shared.Models.Models
{
    public class Rapor
    {
        public Guid UUID { get; set; }
        public string Konum { get; set; }
        public DateTime RaporTalepTarihi => DateTime.Now;
    }

}
