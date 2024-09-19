namespace FirstProject
{
    public delegate void Afficher(string message);

    public class Publisher
    {
        public event Afficher YaUneNews;

        public void Notify()
        {
            // this.YaUneNews("Coucou");
            this.YaUneNews?.Invoke("J'ai vue Leia voler dans le mordor");
        }
    }
}
