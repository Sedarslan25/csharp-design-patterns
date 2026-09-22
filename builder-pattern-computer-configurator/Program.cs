using System;

namespace BuilderPatternKullaniciGirisli
{
    // Ürün (Product)
    public class Bilgisayar
    {
        public string CPU { get; set; } = string.Empty;
        public string RAM { get; set; } = string.Empty;
        public string Depolama { get; set; } = string.Empty;

        public void Goster()
        {
            Console.WriteLine("----- Bilgisayar Özellikleri -----");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Depolama: {Depolama}");
        }
    }

    // Builder Arayüzü
    public interface IBilgisayarBuilder
    {
        void SetCPU();
        void SetRAM();
        void SetDepolama();
        Bilgisayar GetBilgisayar();
    }

    // Kullanıcının girdiği değerlere göre Builder
    public class OzellestirilmisBilgisayarBuilder : IBilgisayarBuilder
    {
        private readonly Bilgisayar _bilgisayar = new Bilgisayar();

        private readonly string _cpu;
        private readonly string _ram;
        private readonly string _depolama;

        public OzellestirilmisBilgisayarBuilder(string cpu, string ram, string depolama)
        {
            _cpu = cpu;
            _ram = ram;
            _depolama = depolama;
        }

        public void SetCPU()
        {
            _bilgisayar.CPU = _cpu;
        }

        public void SetRAM()
        {
            _bilgisayar.RAM = _ram;
        }

        public void SetDepolama()
        {
            _bilgisayar.Depolama = _depolama;
        }

        public Bilgisayar GetBilgisayar()
        {
            return _bilgisayar;
        }
    }

    // Director sınıfı
    public class BilgisayarTeknisyeni
    {
        private IBilgisayarBuilder _builder;

        public BilgisayarTeknisyeni(IBilgisayarBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructBilgisayar()
        {
            _builder.SetCPU();
            _builder.SetRAM();
            _builder.SetDepolama();
        }

        public Bilgisayar GetBilgisayar()
        {
            return _builder.GetBilgisayar();
        }
    }

    // Program (Main)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bilgisayar Oluşturucu (Builder Pattern) ===");

            Console.Write("Lütfen CPU seçiminizi girin: ");
            string cpu = Console.ReadLine() ?? "Belirtilmedi";

            Console.Write("Lütfen RAM miktarını girin (örn: 16GB DDR4): ");
            string ram = Console.ReadLine() ?? "Belirtilmedi";

            Console.Write("Lütfen Depolama türünü girin (örn: 512GB SSD): ");
            string depolama = Console.ReadLine() ?? "Belirtilmedi";

            // Builder oluştur ve bilgisayarı inşa et
            IBilgisayarBuilder builder = new OzellestirilmisBilgisayarBuilder(cpu, ram, depolama);
            BilgisayarTeknisyeni teknisyen = new BilgisayarTeknisyeni(builder);

            teknisyen.ConstructBilgisayar();
            Bilgisayar kullaniciBilgisayari = teknisyen.GetBilgisayar();

            Console.WriteLine();
            kullaniciBilgisayari.Goster();

            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
