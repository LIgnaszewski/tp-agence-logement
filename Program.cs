namespace tp_agence_logement;

class Program
{
    static void Main(string[] args)
    {
        Logement l1 = new Appartement("Antoine", "DAST", 12, 20, false, 2);
        Logement l2 = new Studio("Romain", "SEVRETTE", 12, 20, true, true);
        Logement l3 = new Maison("Lucas", "PEDRAK", 12, 20, true, 2);

        List<Logement> logements = new List<Logement>();
        logements.Add(l1);
        logements.Add(l2);
        logements.Add(l3);

        foreach (Logement log in logements)
        {
            log.Afficher();
        }
    }
}
