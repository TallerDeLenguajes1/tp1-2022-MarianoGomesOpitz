public class DatosProfesionales
{
    string cargo;
    float sueldo;

    public string Cargo { get => cargo; set => cargo = value; }
    public float Sueldo { get => sueldo; set => sueldo = value; }

    public DatosProfesionales() { }
    public DatosProfesionales(string C, float S)
    {
        this.Cargo = C;
        this.Sueldo = S;
    }
}