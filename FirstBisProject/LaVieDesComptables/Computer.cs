namespace LaVieDesComptables
{
    internal class Computer
    {
        public decimal Compute(int amountHT, decimal tva)
        {
            return amountHT * (1 + tva);
        }

        public decimal Compute(int amountHT, GetTva getTva)
        {
            var tva = getTva(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
            return amountHT * (1 + tva);
        }
    }
}
