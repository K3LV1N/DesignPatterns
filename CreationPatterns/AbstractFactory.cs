using System;
using System.Collections.Generic;
using System.Text;

namespace CreationPatterns
{
    public interface ICar
    {
        string Name { get; }
        int Year { get; }
    }

    public enum CarType
    {
        Hatch,
        Sedan
    }

    public interface ISuv
    {
        string Name { get; }
        int Year { get; }
    }

    public enum SuvType
    {
        FourWD,
        CrossOver
    }

    public interface IVehicleFactory
    {
        ICar Create(CarType type);
        ISuv Create(SuvType type);
    }

    public class NissanFactory : IVehicleFactory
    {
        public ICar Create(CarType type)
        {
            switch (type)
            {
                case CarType.Hatch:
                    return new NissanTiida();
                case CarType.Sedan:
                    return new NissanBlueBird();
                default:
                    throw new Exception($"Unknown CarType: {type}");
            }
        }

        public ISuv Create(SuvType type)
        {
            switch (type)
            {
                case SuvType.FourWD:
                    return new NissanTerrano();
                case SuvType.CrossOver:
                    return new NissanDualis();
                default:
                    throw new Exception($"Unknown SuvType: {type}");
            }
        }
    }

    public class NissanTiida : ICar
    {
        public string Name { get; private set; }

        public int Year { get; private set; }

        public NissanTiida() { Name = "Nissan Tiida"; Year = 1996; }
    }

    public class NissanBlueBird : ICar
    {
        public string Name { get; private set; }

        public int Year { get; private set; }

        public NissanBlueBird() { Name = "Nissan Bluebird"; Year = 1998; }
    }

    public class NissanTerrano : ISuv
    {
        public string Name { get; private set; }

        public int Year { get; private set; }

        public NissanTerrano() { Name = "Nissan Terrano"; Year = 1995; }
    }

    public class NissanDualis : ISuv
    {
        public string Name { get; private set; }

        public int Year { get; private set; }

        public NissanDualis() { Name = "Nissan Dualis"; Year = 1999; }
    }


    public class ToyotaFactory : IVehicleFactory
    {
        public ICar Create(CarType type)
        {
            switch (type)
            {
                case CarType.Hatch:
                    return new ToyotaCorolla();
                case CarType.Sedan:
                    return new ToyotaCamry();
                default:
                    throw new Exception($"Unknown CarType: {type}");
            }
        }

        public ISuv Create(SuvType type)
        {
            switch (type)
            {
                case SuvType.FourWD:
                    return new ToyotaHilux();
                case SuvType.CrossOver:
                    return new ToyotaRav4();
                default:
                    throw new Exception($"Unknown SuvType: {type}");
            }
        }
    }

    public class ToyotaCorolla : ICar
    {
        public string Name { get; private set; }

        public int Year { get; private set; }

        public ToyotaCorolla() { Name = "Toyota Corolla"; Year = 1996; }
    }

    public class ToyotaCamry : ICar
    {
        public string Name { get; private set; }

        public int Year { get; private set; }

        public ToyotaCamry() { Name = "Toyota Camry"; Year = 1997; }
    }

    public class ToyotaHilux : ISuv
    {
        public string Name { get; private set; }

        public int Year { get; private set; }

        public ToyotaHilux() { Name = "Toyota Hilux"; Year = 1998; }
    }

    public class ToyotaRav4 : ISuv
    {
        public string Name { get; private set; }

        public int Year { get; private set; }

        public ToyotaRav4() { Name = "Toyota RAV4"; Year = 1995; }
    }

    public class VehicleFactoryClient
    {
        private IVehicleFactory factory;

        public VehicleFactoryClient(IVehicleFactory factory) => this.factory = factory;

        public ICar Create(CarType type) => factory.Create(type);
        public ISuv Create(SuvType type) => factory.Create(type);
    }
}
