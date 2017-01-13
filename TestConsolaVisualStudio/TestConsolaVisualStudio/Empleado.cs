using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaVisualStudio
{
    class Empleado : Persona
    {
        private int legajo;
        private int antiguedad;


        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }
        public int Antiguedad { get
            {
                return this.antiguedad;
            }
            set {
                this.antiguedad = value;
            } }


        public Empleado(int dni, int edad, String nombre,char sexo,int legajo,int antiguedad)
            : base (dni,edad,nombre,sexo)
        {
            this.legajo = legajo;
            this.antiguedad = antiguedad;
        }
        public Empleado() {}

        public override string ToString()
        {
            return base.ToString() +String.Format(",{0},{1}",this.legajo,this.antiguedad);
        }

    }
}
