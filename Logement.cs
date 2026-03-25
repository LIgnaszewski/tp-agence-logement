class Logement
{
    protected string reference;
    protected string adresse;
    protected int surface;
    protected double loyerBase;
    protected bool disponible;

    public Logement(string reference, string adresse, int surface, double loyerBase, bool disponible)
    {
        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
    }

    public bool getDispo()
    {
        return disponible;
    }

    public void Afficher()
    {
        Console.WriteLine($"Reference : {reference}\nAdresse : {adresse}\nSurface : {surface}\nLoyerBase : {loyerBase}\nDisponible : {disponible}");
    }

    public void CalculerLoyer()
    {
        
    }
}