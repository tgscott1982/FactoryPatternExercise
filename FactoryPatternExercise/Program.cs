using FactoryPatternExercise;


Console.WriteLine("What type of vehicle would you like to make?\n" +
    "Press 1 for a regular car. Press 2 for an electric car.");

int fuelType = int.Parse(Console.ReadLine());

var userChoice1 = Factory.GetVehicle(fuelType);

userChoice1.Drive();