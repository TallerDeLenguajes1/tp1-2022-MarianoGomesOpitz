public class DatosPersonales
{
    private string apellido, nombre, fechaNac;
    char sexo, estadoCivil;

    public string Apellido { get => apellido; set => apellido = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string FechaNac { get => fechaNac; set => fechaNac = value; }
    public char Sexo { get => sexo; set => sexo = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

    public DatosPersonales() { }
    public DatosPersonales(string Ape, string Nom, string Fecha, char Sex, char Civ)
    {
        this.Apellido = Ape;
        this.Nombre = Nom;
        this.FechaNac = Fecha;
        this.Sexo = Sex;
        this.EstadoCivil = Civ;
    }
}