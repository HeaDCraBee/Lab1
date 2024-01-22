namespace Lab1.Manufactures.Factorys
{
    internal class VWFactory : ManufacturesFactory
    {
        public override Manufactor Create()
        {
            return new Volkswagen();
        }
    }
}
