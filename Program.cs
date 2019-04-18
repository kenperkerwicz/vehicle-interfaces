using System;
using System.Linq;
using System.Collections.Generic;

namespace LeanAndMean {




public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly

        // With a single `foreach`, have each vehicle Fly()



 LeanAndMean newLean = new LeanAndMean ();

 Broat boaty = new Broat();

 Motorcycle bikey = new Motorcycle();

 Cessna cesnnay = new Cessna ();

 JetSki JetSkiy = new JetSki ();

Plane Planey = new Plane ();

Scooter Scootery = new Scooter ();



// newLean.LandVehicles().ForEach(v => Console.WriteLine($" the {v} is driving"));


// newLean.WaterVehicles().ForEach(v => Console.WriteLine($" the {v} is in the water"));


// newLean.AirVehicles().ForEach(v => Console.WriteLine($" the {v} is in the air"));



newLean.WaterVehicle(JetSkiy);

newLean.AirVehicle(Planey);

newLean.LandVehicle(Scootery);



        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()



        // Build a collection of all vehicles that operate on water

        // With a single `foreach`, have each water vehicle Drive()
    }

}

}