namespace tp_agence_logement;

class Program
{
    static void Main(string[] args)
    {
        Logement l1 = new Logement("qzdqzd", "qzdqzdq", 12, 56, true);
        l1.Afficher();
        if (l1.getDispo() == true ) Console.WriteLine($"Le logement est disponnible.");
        else Console.WriteLine($"Le logement n'est pas disponnible.");
    }
}
