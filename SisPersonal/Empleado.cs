namespace SisPersonal
{
    public enum Cargos{Auxiliar, Administrativo, Ingeniero, Especialista, Investigador};
    public class Empleado{
        private string nombre;
        private string apellido;
        private DateTime fechadenac;
        private char estadoCivil;
        private DateTime ingresoEmpresa;
        private double sueldo; 
        private Cargos cargo;

        
        public string Nombre {get => nombre; set => nombre = value;}
        public string Apellido {get => apellido; set => apellido = value;}
        public DateTime Fechanac {get => fechadenac; set => fechadenac = value;}
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime IngresoEmpresa { get => ingresoEmpresa; set => ingresoEmpresa = value; }
        public double Sueldo { get => sueldo; set => sueldo = value;}
        public Cargos Cargo {get => cargo; set => cargo = value;}

        public int GetEdad(){
            return System.DateTime.Now.Year - fechadenac.Year;
        }
        public int GetAntiguedad(){
            return System.DateTime.Now.Year - ingresoEmpresa.Year;
        }
        public Empleado(string nombre, string apellido, DateTime fechadenac, char estadoCivil, DateTime ingresoEmpresa, double sueldo, Cargos cargo){
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechadenac = fechadenac;
            this.estadoCivil = estadoCivil;
            this.ingresoEmpresa = ingresoEmpresa;
            this.sueldo = sueldo;
            this.cargo = cargo;
        }
        public string Jubilacion()
        {
            int edad = GetEdad();                
            int añosFaltantes = 65 - edad;
            if(edad < 65){
                return($"falta para jubilarse:{añosFaltantes}");
            }else{
                return("cumple los años para la jubilacion.");
            }
        }

        public int paraJubilarse(){
            int edad = GetEdad();
            int añosFaltantes = 65 - edad;
            return añosFaltantes;
        }

        public double salario(){
            double salario;
            double adicional;
            int antiguedad = GetAntiguedad();
            if(antiguedad <= 20){
                adicional = sueldo * antiguedad * 0.01;
            }else{
                adicional = sueldo * 0.25;
            }
            if(Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista){
                adicional *= 1.50;
            }

            if(EstadoCivil == 'C'){
                adicional += 150000;
            }

            salario = sueldo + adicional;
            return salario;
        }
        public string MostrarEmpleado()
        {
            return $"Nombre: {nombre} {apellido}\n" + 
            $"Fecha de Nacimiento: {fechadenac} (Edad: {GetEdad()})\n" +
            $"Estado Civil: {estadoCivil}\n" +
            $"Fecha de Ingreso: {ingresoEmpresa} (Antigüedad: {GetAntiguedad()} años)\n" +
            $"Sueldo: {sueldo}\n" +
            $"Cargo: {cargo}\n" +
            $"Jubilación: {Jubilacion()}\n" +
           $"Salario Total: {salario()}";
        }



    }


}
