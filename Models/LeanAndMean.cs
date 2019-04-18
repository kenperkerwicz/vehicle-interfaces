using System.Collections.Generic;

namespace LeanAndMean

{
public class LeanAndMean {

   public List<Broat> Broats { get; set; } = new List<Broat>();

   public List<Scooter> Scooters { get; set; } = new List<Scooter>();

   public List<Cessna> Cessnas { get; set; } = new List<Cessna>();

   public List<JetSki> JetSkis { get; set; } = new List<JetSki>();

   public List<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();

  public List<Plane> Planes { get; set; } = new List<Plane>();


   public List<ILand> LandVehicles()
    {
      List<ILand> LandVehicles = new List<ILand>() {
          new Motorcycle(),
          new Motorcycle(),
          new Scooter(),
          new Scooter(),
      };
      return LandVehicles ;
    }


public List<IAir> AirVehicles()
    {
      List<IAir> AirVehicles = new List<IAir>() {
          new Cessna(),
          new Cessna(),
          new Plane(),
          new Plane(),
      };
      return AirVehicles ;
    }


    public List<IWater> WaterVehicles()
    {
      List<IWater> WaterVehicles = new List<IWater>() {
          new Broat(),
          new JetSki(),
          new Broat(),
          new JetSki(),
      };
      return WaterVehicles ;
    }



    public void WaterVehicle(IWater watervehicle) {
      watervehicle.Drive();
    }

 public void AirVehicle(IAir airvehicle) {
      airvehicle.Fly();
    }


    public void LandVehicle(ILand landvehicle) {
      landvehicle.Drive();
    }
}
}