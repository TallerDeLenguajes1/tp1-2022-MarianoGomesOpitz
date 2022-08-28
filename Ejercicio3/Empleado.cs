using System;
public class Empleado
{
    private DatosPersonales datPer;
    private Direccion dire;
    private string fechaIngreso;
    private DatosProfesionales datPro;

    public DatosPersonales DatPer { get => datPer; set => datPer = value; }
    public Direccion Dire { get => dire; set => dire = value; }
    public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public DatosProfesionales DatPro { get => datPro; set => datPro = value; }

    public Empleado() { }
    public Empleado(DatosPersonales Per, Direccion D, string Fecha, DatosProfesionales Pro)
    {
        this.DatPer = Per;
        this.Dire = D;
        this.FechaIngreso = Fecha;
        this.DatPro = Pro;
    }

    public int CalcularAtiguedad()
    {
        int anti;
        var fechaAux = DateOnly.Parse(FechaIngreso);
        int aux = DateTime.Now.Year - fechaAux.Year;
        if (fechaAux.Month > DateTime.Now.Month)
        {
            aux--;
        }
        else
        {
            if (fechaAux.Month == DateTime.Now.Month && fechaAux.Day > DateTime.Now.Day)
            {
                aux--;
            }
        }
        anti = aux;
        return (anti);
    }

    public int CalcularEdad()
    {
        int edad;
        var fechaAux = DateOnly.Parse(DatPer.FechaNac);
        int aux = DateTime.Now.Year - fechaAux.Year;
        if (fechaAux.Month > DateTime.Now.Month)
        {
            aux--;
        }
        else
        {
            if (fechaAux.Month == DateTime.Now.Month && fechaAux.Day > DateTime.Now.Day)
            {
                aux--;
            }
        }
        edad = aux;
        return (edad);
    }

    public float CalcularSalario()
    {
        float salario;
        float descuento = DatPro.Sueldo * (float)0.15;
        float adicional;
        int anti = CalcularAtiguedad();
        if (anti >= 20)
        {
            adicional = DatPro.Sueldo * (float)0.20;
        }
        else
        {
            adicional = DatPro.Sueldo * (anti / 100);
        }
        salario = DatPro.Sueldo + adicional - descuento;
        return (salario);
    }
}