using System;
using System.Collections.Generic;

namespace Абстракция
{

	abstract class Animal
	{
		public abstract void Print();

	}

	class Dog : Animal
	{

		private float speed;

		public Dog(float speed)
		{
			this.speed = speed;
		}

		public override void Print()
		{
			Console.WriteLine("Dog speed: " + speed);
		}
	}

	class Cat : Animal
	{

		private float speed;

		public Cat(float speed)
		{
			this.speed = speed;
		}

		public override void Print()
		{
			Console.WriteLine("Cat speed: " + speed);
		}
	}

	class MainClass
	{

		public static void Main(string[] args)
		{

			List<Animal> animals = new List<Animal>();
			animals.Add(new Dog(12.23f));
			animals.Add(new Dog(12.3f));
			animals.Add(new Cat(12.3f));

			foreach (Animal animal in animals)
			{
				animal.Print();
			}

			Console.ReadKey();
		}
	}
}
