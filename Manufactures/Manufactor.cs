namespace Lab1.Manufactures
{
    internal abstract class Manufactor
    {
        public int BasePrice { get; protected set; }

        public Dictionary<string, int> ModelsList { get; protected set; }

        public int LeatherPrice { get; protected set; }

        public int AlcantaraPrice { get; protected set; }

        public int TyresPrice { get; protected set; }

        public int ImprovedSoundSystemPrice { get; protected set; } 

        public int PaintProtectionPrice { get; protected set; }

        public void SetBasePrice(string modelName)
        {
            if (ModelsList.ContainsKey(modelName))
                BasePrice = ModelsList[modelName];
        }
    }
}
