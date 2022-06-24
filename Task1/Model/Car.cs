using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class Car
    {
        private double fuelCounts = 0;


        protected int Id { get; set; }

        protected Type Type { get; set; }

        protected double LitersFuelConsumption { get; set; }

        protected double KilometersFuelConsumption { get; set; }

        protected double FuelCount { 
            get
            {
                return fuelCounts;
            }
            set
            {
                fuelCounts = value > FuelTankVolume ? FuelTankVolume : value;
            } 
        }

        protected double FuelTankVolume { get; set; }

        protected double SpeedKilometers { get; set; }

        protected double SpeedTime { get; set; }


        public Car(int id, double litersFuelConsumption, double kilometersFuelConsumption, double fuelCount, double fuelTankVolume, double speedKilometers, double speedTime, Type type = null)
        {
            Id = id;
            Type = type;
            LitersFuelConsumption = litersFuelConsumption;
            KilometersFuelConsumption = kilometersFuelConsumption;
            FuelTankVolume = fuelTankVolume;
            FuelCount = fuelCount;
            SpeedKilometers = speedKilometers;
            SpeedTime = speedTime;
        }


        public SuperCar ToSuperCar()
        {
            return new SuperCar(Id, LitersFuelConsumption, KilometersFuelConsumption, FuelCount, FuelTankVolume, SpeedKilometers, SpeedTime);
        }

        public SmallCar ToSmallCar(int MaxCounPassager, int CountPassager)
        {
            return new SmallCar(Id, CountPassager, LitersFuelConsumption, KilometersFuelConsumption, FuelCount, FuelTankVolume, SpeedKilometers, SpeedTime, MaxCounPassager);
        }

        public BigCar ToBigCar(double MaxLoadCapacity, double LoadCapacity)
        {
            return new BigCar(Id, LoadCapacity, LitersFuelConsumption, KilometersFuelConsumption, FuelCount, FuelTankVolume, SpeedKilometers, SpeedTime, MaxLoadCapacity);
        }


        public virtual TimeSpan TripDurationToTime()
        {
            double speedCof = SpeedKilometers / SpeedTime;

            return TimeSpan.FromHours(TripDurationToDistance() / speedCof);
        }

        public virtual double TripDurationToDistance()
        {
            try
            {
                double fuelConsumption = LitersFuelConsumption / KilometersFuelConsumption;

                return FuelCount / fuelConsumption;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
