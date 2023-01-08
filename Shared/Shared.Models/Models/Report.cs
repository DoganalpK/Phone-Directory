namespace Shared.Models.Models
{
    public class Report
    {
        public Guid UUID { get; set; }
        public string Konum { get; set; }
        public int KisiSayisi { get; set; }
        public int TelefonNumarasiSayisi { get; set; }
        public DateTime RaporTalepTarihi { get; set; }
    }

    public enum ReportStatus
    {
        Hazirlaniyor = 0,
        Tamamlandi = 1,
    }
}
