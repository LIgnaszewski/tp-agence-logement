class Maison : Logement
{
    protected int surfaceJardin;

    public Maison(string reference, string adresse, int surface, double loyerBase, bool disponible, int surfaceJardin):base(reference, adresse, surface, loyerBase, disponible)
    {
        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
        if (surfaceJardin > 0 || surfaceJardin == null) this.surfaceJardin = surfaceJardin;
    }

    public override void Afficher()
    {
        Console.WriteLine($"Reference : {reference} | Adresse : {adresse} | Surface : {surface} | LoyerBase : {loyerBase} | Disponible : {disponible} | SurfaceJardin : {surfaceJardin} | Loyer Final : {CalculerLoyer()}€");
    }

    public override double CalculerLoyer()
    {
        return (loyerBase + (10 * surfaceJardin));
    }
}