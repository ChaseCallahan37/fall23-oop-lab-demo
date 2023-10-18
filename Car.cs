namespace OOP_Lab_Demo{
	public class Car{
		private string name;
		private int speed;

		public Car(string name){
			this.name = name;
			this.speed = 0;
		}

		public string GetName(){
			return name;
		}

		public void GoFast(int speedUp){
			Console.WriteLine($"{name} is currently going {speed} and is speeding up to {speed + speedUp}!");
			speed += speedUp;
		}

		public void SlowDown(int slowDown){
			Console.WriteLine($"Srhhhhheeeechhhhhh! {name} is currently going {speed} and is slowing down {speed - slowDown}!!! (Get out of the way, he is almost driving as bad as Chase!)");		
		}
	}
}
