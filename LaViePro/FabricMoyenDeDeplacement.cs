namespace LaViePro
{
    internal static class FabricMoyenDeDeplacement
    {
        private static Dictionary<Meteo, IMoyenDeDeplacement> values = new()
        {
            { Meteo.Beau, new Velo() },
            { Meteo.TresBeau, new Moto() },
            { Meteo.Pluie, new Voiture() },
            { Meteo.Orage, new Train() },
        };

        public static IMoyenDeDeplacement Create(Meteo meteo)
        {
            return values[meteo];
        }
    }
}
