namespace Shared.Models.Models
{
    public class Rapor
    {
        public Guid UUID { get; set; }
        public DateTime RaporTalepTarihi => DateTime.Now;
    }

}
