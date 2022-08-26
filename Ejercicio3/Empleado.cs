public class Empleado
{
    private DatosPersonales datPer;
    private Direccion dire;
    private string fechaIngreso, cargo;
    
    public Datos DatPer { get => dat; set => dat = value; }
    public Direccion Dire { get => dire; set => dire = value; }
    public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public string Cargo { get => cargo; set => cargo = value; }
}