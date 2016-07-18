using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Persona
    {
        public int id;// { get; set; }
        public int dameid()
        {
            return id;
        }
    }
    class Alumno : Persona
    {
        public int Edad { get; set; }//Atributo 1
        public string Nombre { get; set; }//Atributo 2
        public string Apellido { get; set; }//Atributo 3

        //Metodo Nombrecompleto
        public void NombreCompleto()
        {
            Console.WriteLine(Nombre + " " + Apellido);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos clase alumno
            Alumno david1 = new Alumno();
            david1.Nombre = "David";
            david1.Apellido = "Silva";
            david1.Edad = 12;
            david1.NombreCompleto();

            Alumno david2 = new Alumno();

            Console.ReadLine();
        }
    }
}