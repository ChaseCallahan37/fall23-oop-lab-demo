using OOP_Lab_Demo;

Car coolCar = new Car("Lightning McQueen");

System.Console.WriteLine("How fast should " + coolCar.GetName() + " be going?");
int speedInput = int.Parse(Console.ReadLine());
coolCar.SpeedUp(speedInput);

System.Console.WriteLine($"Uh oh... {coolCar.GetName()} has a flat, how much should he slow down by?");
speedInput = int.Parse(Console.ReadLine());
coolCar.SlowDown(speedInput);



