using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class BigCar : Car
    {
        private double loadCapacity = 7500;


        public double MaxLoadCapacity { get; set; }

        public double LoadCapacity
        {
            get
            {
                return loadCapacity;
            }
            set
            {
                loadCapacity = value > MaxLoadCapacity ? MaxLoadCapacity : value;
            }
        }

        public BigCar(int id, double loadCapacity, double litersFuelConsumption, double kilometersFuelConsumption, double fuelCount, double fuelTankVolume, double speedKilometers, double speedTime, double maxLoadCapacity = 7500, Type type = null) : base(id, litersFuelConsumption, kilometersFuelConsumption, fuelCount, fuelTankVolume, speedKilometers, speedTime, type = Type.Types.Find(i => i.Id == 2))
        {
            MaxLoadCapacity = maxLoadCapacity;
            LoadCapacity = loadCapacity;
        }

        public override double TripDurationToDistance()
        {
            try
            {
                double distace = base.TripDurationToDistance();
                double cargoExpencse = distace * 4 / 100 * (LoadCapacity / 200);

                return distace - cargoExpencse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
