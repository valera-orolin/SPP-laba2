namespace Test.Classes.SimpleClasses {

	public class User {
		
		private int id;
		private string name;
		private string password;
		public double rating;
		
		public User(string name) {
			this.name = name;
		}
		
		public User(string name, int id, string password) {
			this.name = name;
			this.id	= id;
			this.password = password;
		}

		public void showInfo() {
			Console.WriteLine($"Name: {name}\nPassword: {password}\nId: {id}\nRating: {rating}\n");
		}
	}
}