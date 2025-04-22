using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Veterinario
    {
        public void TratarAnimal(Animal animal)
        {
            Console.WriteLine("O animal " + animal.Nome + " esta sendo tratado");
        }

        public void ChecarRaca(Cachorro animal)
        {
            Console.WriteLine("A raca do animal é " + animal.Raca);
        }
    }
}
