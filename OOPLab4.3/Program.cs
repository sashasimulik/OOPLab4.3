using System;

namespace OOPLab4._3
{
	public class Test
	{

		class Note
		{

			private string number = "Введiть данi";
			private string nametag = "Введiть даннi для заповнення";
			private string make = "Введiть даннi для заповнення";
			private string price = "Введiть даннi для заповнення ";
			private string quantity = "Введiть даннi для заповнення";

			public Note()
			{
				number = "Введiть данi";
				nametag = "Введiть данi";
				make = "Введiть данi";
				price = "Введiть данi";
				quantity = "Введiть данi";
			}

			public Note(string n, string na, string m, string p, string q)
			{
				number = n;
				nametag = na;
				make = m;
				price = p;
				quantity = q;
			}

			public void setNumber(string n)
			{
				number = n;
			}

			public string getNumber()
			{
				return number;
			}

			public void setNametag(string na)
			{
				nametag = na;
			}

			public string getNametag()
			{
				return nametag;
			}

			public void setMake(string m)
			{
				make = m;
			}

			public string getMake()
			{
				return make;
			}

			public void setPrice(string p)
			{
				price = p;
			}

			public string getPrice()
			{
				return price;
			}

			public void setQuantity(string q)
			{
				quantity = q;
			}

			public string getQuantity()
			{
				return quantity;
			}

			public void add()
			{
				Console.WriteLine("Введiть номер:");
				number = Console.ReadLine();

				Console.WriteLine("Введiть назву:");
				nametag = Console.ReadLine();

				Console.WriteLine("Введiть марку:");
				make = Console.ReadLine();

				Console.WriteLine("Введiть цiну:");
				price = Console.ReadLine();

				Console.WriteLine("Введiть кiлькiсть:");
				quantity = Console.ReadLine();
			}

			public void edit()
			{
				Console.WriteLine("Введiть номер:");
				number = Console.ReadLine();

				Console.WriteLine("Введiть назву:");
				nametag = Console.ReadLine();

				Console.WriteLine("Введiть марку:");
				make = Console.ReadLine();

				Console.WriteLine("Введiть цiну:");
				price = Console.ReadLine();

				Console.WriteLine("Введiть кiлькiсть:");
				quantity = Console.ReadLine();
			}

			public void del()
			{
				number = "delete";
				nametag = "delete";
				make = "delete";
				price = "delete";
				quantity = "delete";
			}

			public void print()
			{
				Console.WriteLine("Номер: " + number);
				Console.WriteLine("Назва: " + nametag);
				Console.WriteLine("Марка: " + make);
				Console.WriteLine("Цiна: " + price);
				Console.WriteLine("Кiлькiсть: " + quantity);
			}
		}

		class Date
		{

			public Note[] arr = new Note[10];

			public Date()
			{
				for (int i = 0; i < 10; i++)
				{
					arr[i] = new Note();
				}
			}

			public void sort()
			{
				Array.Sort(arr);
			}

			public void find()
			{

				string z = "";
				Console.WriteLine("Ввеiть номер для пошуку: ");
				z = Console.ReadLine();
				bool x = true;

				for (int i = 0; i < 10; i++)
				{
					if (String.Equals(arr[i].getNumber(), z))
					{
						arr[i].print();
						x = false;
					}
				}

				if (x)
				{
					Console.WriteLine("Номер: " + z + " Не iснує");
				}

			}

			public void add()
			{
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine("Додати елемент" + i);
					arr[i].add();
				}
			}

			public void edit()
			{
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine("Змiнити елемент" + i);
					arr[i].edit();
				}
			}

			public void print()
			{
				for (int i = 0; i < 10; i++)
				{
					arr[i].print();
					Console.WriteLine("--------------------------");
				}
			}

		}


		public static void Main()
		{
			Date d1 = new Date();
			d1.print();

			string s = "";

			Console.WriteLine("Оберiть опцiю меню: ");
			Console.WriteLine("1. Додати новий запис, натиснiть a");
			Console.WriteLine("2. Редагувати запис, натиснiть e");
			Console.WriteLine("3. Знайти запис, натиснiть f");
			Console.WriteLine("4. Для виходу з програми натиснiть x");
			s = Console.ReadLine();

			switch (s)
			{
				case "a":
					d1.add();
					break;
				case "e":
					d1.edit();
					break;
				case "f":
					d1.find();
					break;
				case "x":
					Console.WriteLine("Вихiд");
					break;
			}


		}
	}

}
