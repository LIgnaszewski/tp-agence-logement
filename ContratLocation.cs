class ContratLocation
{
    public int numero;
    public Locataire locataire;
    public Logement logement;
    public int nombreJours;
    public double tarifJournalier;

    public ContratLocation(int numero, Locataire locataire, Logement logement, int nombreJours, double tarifJournalier)
    {

        if (logement.getDispo() == true)
        {
            this.numero = numero;
            this.locataire = locataire;
            this.logement = logement;
            if (nombreJours >=1) this.nombreJours = nombreJours;
            else this.nombreJours = 1;
            this.tarifJournalier = tarifJournalier;
            logement.setDispo(false);
        } else
        {
            Console.WriteLine("La création du contrat n'est pas possible puisque le logement n'est pas disponible.");
        }
    }

    public virtual void Afficher()
    {
        Console.WriteLine($"Numéro : {numero} | Locataire : {locataire} | Logement : {logement} | Nombre de Jour : {nombreJours} | Tarif Journalier : {tarifJournalier} | Montant Total : {CalculerMontantTotal()}");
    }

    public double CalculerMontantTotal()
    {
        return nombreJours * tarifJournalier;
    }

}