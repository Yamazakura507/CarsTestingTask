using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class SmallCar : Car
    {
        private int countPassenger = 8;


        public int MaxCountPassenger { get; set; }

        public int CountPassenger 
        { 
            get
            { 
                return countPassenger;
            }
            set
            { 
                countPassenger = value > MaxCountPassenger ? MaxCountPassenger : value;
            } 
        }

        public SmallCar(int id, int countPassenger, double litersFuelConsumption, double kilometersFuelConsumption, double fuelCount, double fuelTankVolume, double speedKilometers, double speedTime, int maxCountPassenger = 8, Type type = null) 
            : base(id, litersFuelConsumption, kilometersFuelConsumption, fuelCount, fuelTankVolume, speedKilometers, speedTime, type = Type.Types.Find(i => i.Id == 1))
        {
            MaxCountPassenger = maxCountPassenger;
            CountPassenger = countPassenger;
        }

        public override double TripDurationToDistance()
        {
            try
            {
                double distace = base.TripDurationToDistance();
                double passengerExpencse = distace * 6 / 100 * CountPassenger;

                return distace - passengerExpencse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
