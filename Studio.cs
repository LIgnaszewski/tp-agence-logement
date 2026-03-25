class Studio : Logement
{
    protected bool meuble;

    public Studio(string reference, string adresse, int surface, double loyerBase, bool disponible, bool meuble):base(reference, adresse, surface, loyerBase, disponible)
    {
        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
        this.meuble = meuble;
    }

    public override void Afficher()
    {
        Console.WriteLine($"Reference : {reference} | Adresse : {adresse} | Surface : {surface} | LoyerBase : {loyerBase} | Disponible : {disponible} | Meuble : {meuble} | Loyer Final : {CalculerLoyer()}€");
    }

    public override double CalculerLoyer()
    {
        if (meuble == true) return loyerBase + 50;
        else return loyerBase;
    }
}