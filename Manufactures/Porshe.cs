namespace Lab1.Manufactures
{
    internal class Porshe : Manufactor
    {
        public Porshe()
        {
            Name = "Porshe";

            ModelsList = new()
            {
                { "911", 150000.0m },
                { "718", 60000.0m },
                { "Macan", 50000.0m },
                { "Cayenne", 110000.0m }
            };

            LeatherPrice = 1000.0m;
            AlcantaraPrice = 2000.0m;
            TyresPrice = 500.0m;
            ImprovedSoundSystemPrice = 350.0m;
            PaintProtectionPrice = 100.0m;
        }
    }
}
