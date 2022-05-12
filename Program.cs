using System;
using RPG_DIO.src.Entities;

namespace RPG_DIO
{

	class program
	{

		static void Main(string[] args)
		{
			Hero arus = new Knight("Arus", 23, "Knight");
			Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
			Ninja wedge = new Ninja("Wedge", 42, "Ninja");
			Black topapa = new Black("Topapa", 42, "Black Wizard");


			Console.WriteLine(wizard.Attack(1));
			Console.WriteLine(wizard.Attack(7));
			Console.WriteLine(arus.Attack());
			Console.WriteLine(topapa.Attack());
			Console.WriteLine(wedge.Attack());

		}
	}
}