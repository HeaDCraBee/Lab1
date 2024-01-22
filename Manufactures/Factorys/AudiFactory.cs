namespace Lab1.Manufactures.Factorys
{
    internal class AudiFactory : ManufacturesFactory
    {
        public override Manufactor Create()
        {
            return new Audi();
        }
    }
}
