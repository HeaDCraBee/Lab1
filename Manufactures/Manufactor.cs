namespace Lab1.Manufactures
{
    internal abstract class Manufactor
    {
        public string Name { get; protected set; }
        public decimal BasePrice { get; protected set; }

        public Dictionary<string, decimal> ModelsList { get; protected set; }

        public decimal LeatherPrice { get; protected set; }

        public decimal AlcantaraPrice { get; protected set; }

        public decimal TyresPrice { get; protected set; }

        public decimal ImprovedSoundSystemPrice { get; protected set; } 

        public decimal PaintProtectionPrice { get; protected set; }

        public string SelectedModel { get; protected set; }

        public void SetModel(string modelName)
        {
            if (ModelsList.ContainsKey(modelName))
            {
                SelectedModel = modelName;
                BasePrice = ModelsList[modelName];
            }
        }
    }
}
