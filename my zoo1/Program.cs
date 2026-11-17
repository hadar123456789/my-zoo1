
using my_zoo1;

Dog dog= new Dog() { Name = "jony", Weight = 5 };
Cat cat = new Cat() { Name = "fluffy", Weight = 3 };
Donkey donkey = new Donkey() { Name = "bruno", Weight = 100 };




List<Animal> animals = new List<Animal>() { dog, cat, donkey };
foreach (var animal in animals)
{
    Console.WriteLine(animal.SayHello());
    Thread.Sleep(1000);
}