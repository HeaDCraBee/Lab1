namespace Lab1.Manufactures
{
    internal class Volkswagen : Manufactor
    {
        public Volkswagen()
        {
            Name = "Volkswagen";

            ModelsList = new()
            {
                { "Polo", 30000.0m },
                { "Golf", 40000.0m },
                { "Passat", 50000.0m },
                { "Tiguan", 60000.0m },
                { "Tuareg", 70000.0m }
            };

            LeatherPrice = 500.0m;
            AlcantaraPrice = 1000.0m;
            TyresPrice = 250.0m;
            ImprovedSoundSystemPrice = 150.0m;
            PaintProtectionPrice = 500.0m;
        }
    }
}
