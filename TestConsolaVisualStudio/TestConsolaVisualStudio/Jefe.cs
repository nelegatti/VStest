using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaVisualStudio
{
    class Jefe : Empleado
    {
        private double sueldo;
        private int nroSucursal;

        public double Sueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                this.sueldo = value;
            }
        }
        public int NroSucursal
        {
            get
            {
                return this.nroSucursal;
            }
            set
            {
                this.nroSucursal = value;
            }
        
        }

        public Jefe(int dni,int edad, String nombre,char sexo,int legajo,int antiguedad,double sueldo, int nroSucursal)
            : base(dni, edad, nombre, sexo,legajo,antiguedad)
        {
            this.sueldo = sueldo;
            this.nroSucursal = nroSucursal;
        }

        public void Contrata(ref Empleado e)
        {
            Console.WriteLine("La antigüedad antes de contratarlo era:{0}", e.Antiguedad);
            e.Antiguedad = 0;
            Console.WriteLine("La nueva antigüedad:{0}", e.Antiguedad);
        }
    }
}
