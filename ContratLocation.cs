class ContratLocation
{
    public int numero;
    public Locataire locataire;
    public Logement logement;
    public int nombreJours;
    public double tarifJournalier;

    public ContratLocation(int numero, Locataire locataire, Logement logement, int nombreJours, double tarifJournalier)
    {
        this.numero = numero;
        this.locataire = locataire;
        this.logement = logement;
        this.nombreJours = nombreJours;
        this.tarifJournalier = tarifJournalier;
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