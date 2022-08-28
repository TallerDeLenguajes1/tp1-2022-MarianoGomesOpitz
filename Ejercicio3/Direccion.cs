public class Direccion
{
    private string calle;
    private int numero;

    public string Calle { get => calle; set => calle = value; }
    public int Numero { get => numero; set => numero = value; }
    public Direccion() { }
    public Direccion(string C, int N)
    {
        this.Calle = C;
        this.Numero = N;
    }
}