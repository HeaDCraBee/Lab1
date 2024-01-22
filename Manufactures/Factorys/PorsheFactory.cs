namespace Lab1.Manufactures.Factorys
{
    internal class PorsheFactory : ManufacturesFactory
    {
        public override Manufactor Create()
        {
            return new Porshe();
        }
    }
}
