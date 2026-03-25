class Appartement : Logement
{
    protected int nombrePiece;

    public Appartement(string reference, string adresse, int surface, double loyerBase, bool disponible, int nombrePiece):base(reference, adresse, surface, loyerBase, disponible)
    {
        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
        if (nombrePiece > 1) this.nombrePiece = nombrePiece;
        else this.nombrePiece = 1;
    }

    public override void Afficher()
    {
        Console.WriteLine($"Reference : {reference} | Adresse : {adresse} | Surface : {surface} | LoyerBase : {loyerBase} | Disponible : {disponible} | Nombre De Piece : {nombrePiece}");
    }
}