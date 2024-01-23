namespace Lab1.Manufactures
{
    internal class Audi : Manufactor
    {
        public Audi()
        {
            Name = "Audi";

            ModelsList = new()
            {
                { "A3", 40000.0m },
                { "A4", 50000.0m },
                { "A5", 60000.0m },
                { "A6", 70000.0m }
            };

            LeatherPrice = 750.0m;
            AlcantaraPrice = 1500.0m;
            TyresPrice = 300.0m;
            ImprovedSoundSystemPrice = 200.0m;
            PaintProtectionPrice = 750.0m;
        }
    }
}
