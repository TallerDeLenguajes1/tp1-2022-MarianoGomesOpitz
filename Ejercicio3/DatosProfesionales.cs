public class DatosProfesionales
{
    string cargo, titulo, universidad;
    float sueldo;

    public string Cargo { get => cargo; set => cargo = value; }
    public float Sueldo { get => sueldo; set => sueldo = value; }
    public string Titulo { get => titulo; set => titulo = value; }
    public string Universidad { get => universidad; set => universidad = value; }

    public DatosProfesionales() { }
    public DatosProfesionales(string C, float S)
    {
        this.Cargo = C;
        this.Sueldo = S;
    }
}