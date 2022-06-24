using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class SuperCar : Car
    {
        public SuperCar(int id, double litersFuelConsumption, double kilometersFuelConsumption, double fuelCount, double fuelTankVolume, double speedKilometers, double speedTime, Type type = null) : base(id, litersFuelConsumption, kilometersFuelConsumption, fuelCount, fuelTankVolume, speedKilometers, speedTime, type = Type.Types.Find(i => i.Id == 3))
        {
        }
    }
}
