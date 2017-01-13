using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaVisualStudio
{
    class Program
    {
        delegate int del(int aux);
        static void Main(string[] args)
        {
            Persona p = new Persona(37310080, 23, "Orlando", 'M');
            Empleado e = new Empleado(37381920, 22, "Martin", 'F',38039,2);
            Empleado e1 = new Empleado(37381920, 22, "Jesus", 'M', 38040, 3);
            Empleado e2 = new Empleado(37381921, 23, "Gustavo", 'F', 38041, 4);
            Empleado e3 = new Empleado(37381922, 23, "Julio", 'M', 38042, 5);
            Console.WriteLine("La persona creada es: "+p.ToString());
            Console.WriteLine("El empleado creado es:" + e.ToString());

            Jefe j = new Jefe(22345829, 38, "Diego", 'F',29554,2,290.9,110);
            
            Empresa emp1 = new Empresa("Everis", "San Martin 757");
            emp1.ContratarEmpleado(j,e);
            emp1.ContratarEmpleado(j, e1);
            emp1.ContratarEmpleado(j, e2);
            emp1.ContratarEmpleado(j, e3);
            emp1.SetLegajosEmpleados(emp1.Empleados);
            /* Console.WriteLine("---Ingreso a expresión lambda---");
             del newDelegate = anti => anti + 1;
             e.Antiguedad = newDelegate(e.Antiguedad);
             Console.WriteLine("Se produce expresión lambda");
             Console.WriteLine("La nueva antiguedad es: {0}", e.Antiguedad);*/

            foreach(Empleado emp in emp1.Empleados)
            {
                int auxLegajo = 1000;
                if(emp != null)
                {
                    Console.WriteLine("Legajo antiguo:{0}", emp.Legajo);
                    del setLegajo = newLegajo => auxLegajo + 1;
                    emp.Legajo = setLegajo(emp.Legajo);
                    Console.WriteLine("Legajo Asignado:{0}", emp.Legajo);
                    auxLegajo++;
                }else
                {
                    Console.WriteLine("Fin de Cadena o elemento nulo- Break");
                    break;
                }
            }
        }
    }
}
