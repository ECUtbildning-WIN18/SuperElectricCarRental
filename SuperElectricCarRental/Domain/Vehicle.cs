using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain {
  abstract class Vehicle {
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public DateTime CreationDate { get; set; }
    public int Range { get; set; }
  }
}
