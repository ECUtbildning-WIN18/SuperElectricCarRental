using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain {
  class Car : Vehicle {
    public void StartEngine() {
      Console.WriteLine("VROOOMMM....");
    }
  }
}
