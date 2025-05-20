using ConsoleApp1.Classes;

List<Animal> listaDeAnimais = new List<Animal>();

Animal dog = new Cachorro("dog", " vira-lata");
Animal cat = new Gato("cat");

listaDeAnimais.Add(dog);
listaDeAnimais.Add(cat);

for(int i = 0; i < listaDeAnimais.Count; i++)
{
    listaDeAnimais[i].EmitirSom();
}

Veterinario veterinario = new Veterinario();
veterinario.TratarAnimal(dog);
veterinario.ChecarRaca((Cachorro)dog);