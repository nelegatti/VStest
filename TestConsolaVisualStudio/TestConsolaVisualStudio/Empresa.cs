using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaVisualStudio
{
    class Empresa
    {
        private int i = 0;
        private String nombre;
        private String domicilio;
        private Empleado[] empleados = new Empleado[10];


        public Empresa(String nombre,String domicilio)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
        }
        public Empresa()
        {

        }
        public String Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public String Domicilio
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
       public Empleado[] Empleados
        {
            get
            {
                return this.empleados;
            }
            set
            {
                empleados = value;
            }
        }

        public void ContratarEmpleado(Jefe j,Empleado e)
        {
            Console.WriteLine("La empresa {0} ordena a {1} contratar un empleado", this.nombre, j.Nombre);
            j.Contrata(ref e);
            Console.WriteLine("El Jefe {0} va a contratar a {1}",j.Nombre,e.Nombre +" Con una experiencia de {0}",e.Antiguedad);
            try
            {
                empleados[i] = e;
            }
            catch(NullReferenceException nu)
            {
                Console.WriteLine("NULL REFERENCE EXCEPTION" + nu);
            }

            
            Console.WriteLine("Luego de contratado la experiencia nueva es {0}", e.Antiguedad);
            i++;
        }

        public override string ToString()
        {
            return base.ToString()+String.Format(this.nombre+this.domicilio);
        }

        public void SetLegajosEmpleados(Empleado[] e)
        {
            int auxLeg = 1000;
            
            foreach (Empleado emp in e)
            {
                if (emp != null)
                {
                    //FIXME NO SE SETEAN LOS LEGAJOS !!!!!¡¡¡¡!!¡¡¡!!¡¡!!
                    emp.Legajo = ++auxLeg;
                    Console.WriteLine("--El empleado {0} Tiene asignado el legajo:{1}--", emp.Legajo, emp.Legajo);
                }
                else
                {
                    break;
                }
            }
        }

    }
}
