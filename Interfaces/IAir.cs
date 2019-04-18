using System;
using System.Linq;
using System.Collections.Generic;

namespace LeanAndMean {
  public interface IAir
{
     int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    bool Winged { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    double MaxLandSpeed { get; set; }
    double MaxAirSpeed { get; set; }
    void Start();
    void Stop();
    void Drive();
    void Fly();
}

}