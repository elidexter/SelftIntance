using System;
using System.Collections.Generic;
using System.Text;

namespace SelftIntance
{
    class PersonaModel
    {
        public PersonaModel()
        {

        }
        public void SayHello()
        {
            Console.WriteLine("Hello Persona");
        }
        public string Nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public override string ToString()
        {
            return "Soy PersonaModel";
        }
    }
}
