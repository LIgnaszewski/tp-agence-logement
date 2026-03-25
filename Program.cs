namespace tp_agence_logement;

class Program
{
    static void Main(string[] args)
    {
        Logement l1 = new Appartement("Antoine", "DAST", 12, 20, false, 2);
        l1.Afficher();

        Logement l2 = new Studio("Romain", "SEVRETTE", 12, 20, true, true);
        l2.Afficher();

        Logement l3 = new Maison("Lucas", "PEDRAK", 12, 20, true, 2);
        l3.Afficher();
    }
}
