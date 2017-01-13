using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaVisualStudio
{
    class Persona
    {
        private int dni;
        private int edad;
        private String nombre;
        private char sexo;

        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                this.edad = value;
            }
        }
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public char Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                this.sexo = value;
            }
        }

        public Persona() { }

        public Persona(int dni, int edad, String nombre, char sexo)
        {
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
            this.sexo = sexo;
        }
        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3}" ,this.dni, this.edad, this.nombre, this.sexo);
        }
    }
}
