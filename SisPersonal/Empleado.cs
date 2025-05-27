
public class Empleado{
    private string nombre;
    private string apellido;
    private DateTime fechadenac;
    private char estadoCivil;
    private DateTime ingresoEmpresa;
    private double sueldo; 

    private enum Cargos{Auxiliar, Administrativo, Ingeniero, Especialista, Investigador};
    
    public string Nombre {get => nombre; set => nombre = value;}
    public string Apellido {get => apellido; set => apellido = value;}
    public DateTime Fechanac {get => fechadenac; set => fechadenac = value;}
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime IngresoEmpresa { get => ingresoEmpresa; set => ingresoEmpresa = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }

    public int GetEdad(){
        return fechadenac.Year - System.DateTime.Now.Year;
    }
    public int GetAntiguedad(){
        return ingresoEmpresa.Month - System.DateTime.Now.Month;
    }
    public Empleado(string nombre, string apellido, DateTime fechadenac, char estadoCivil, DateTime ingresoEmpresa, double sueldo){
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechadenac = fechadenac;
        this.estadoCivil = estadoCivil;
        this.ingresoEmpresa = ingresoEmpresa;
        this.sueldo = sueldo;
    }
    public string mostrarEmpleado(){
        return "nombre:"+ nombre + "apellido:"+ apellido + "fecha nac:" + fechadenac + "estado civil:" +estadoCivil + "Fecha ingreso:"+ingresoEmpresa + "sueldo" +sueldo;
    }

}
