namespace KasaHesap.Models
{
    public class KasaHesap
    {
        public int Id { get; set; }
        public float PortalEmanet { get; set; }
        public float BankaEmanet { get; set; }
        public float PortalHarc { get; set; }
        public float BankaHarc { get; set; }
        public float GelirVergisi { get; set; }
        public float DamgaVergisi { get; set; }
        public float EldeSayilanMiktar { get; set; }
        public float ProvizyondaBekleyenTutar { get; set; }
        public float SlipToplam { get; set; }

    }
}
