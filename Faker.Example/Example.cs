using Faker.Core;
//using Test.Classes.SimpleClasses;
using System.Collections.Generic;

namespace Faker.Example {
	class User {
		string name;
		public string password;
		public int id;
		public int rating;

		public User(string name) {
			this.name = name;
		}

		public User(string name, string password) {
			this.name = name;
			this.password = password;
		}

		public void showInfo() {
			Console.WriteLine("Name: " + name + "\nPassword: " + password + 
				"\nId: " + id.ToString() + "\nRating: " + rating.ToString());
		}
	}
	class Example {

		public static void Main() {

			Core.Faker fkr = new Core.Faker();


			int randomInt = 0;
			float randomFloat = 0.0F;
			double randomDouble = 0.0;
			string randomString = "";
			randomInt = fkr.Create<int>();
			randomFloat = fkr.Create<float>();
			randomDouble = fkr.Create<double>();
			randomString = fkr.Create<string>();
			Console.WriteLine($"Int: {randomInt}\nFloat: {randomFloat}\nDouble: {randomDouble}\n" +
				$"String: {randomString}\n");


			User user = new User("Valera");
			user = fkr.Create<User>();
			Console.WriteLine("User:");
			user.showInfo();


			DateTime dt = new DateTime();
			dt = fkr.Create<DateTime>();
			Console.WriteLine($"Date and Time: {dt.ToString()}\n");


			List<int> list = fkr.Create<List<int>>();
			Console.WriteLine("List of ints:");
			list.ForEach(Console.WriteLine);


			List<User> userList = fkr.Create<List<User>>();
			Console.WriteLine("\nList of users:");
			foreach (User usr in userList) {
				usr.showInfo();
			}
		}
	}
}