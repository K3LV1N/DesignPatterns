using System;
using System.Collections.Generic;
using System.Text;

namespace CreationPatterns
{
    public enum PokemonType
    {
        Water,
        Electric,
        Fire,
        Leaf,
        Darkness,
        Psychic
    }

    public enum PokemonRegion
    {
        Kanto,
        Kalos,
        Alola
    }

    public class Pokemon
    {
        private string _name;
        private PokemonType _type;
        private int _healthPoints;
        private PokemonType _weakness;
        private PokemonRegion _origin;

        public string Name { get => _name; }

        public PokemonType Type { get => _type; }
        public int HealthPoints { get => _healthPoints; }
        public PokemonType Weakness { get => _weakness; }
        public PokemonRegion Origin { get => _origin; }

        public void SetName(string name) { if (string.IsNullOrEmpty(name)) { throw new ArgumentException("message", nameof(name)); } _name = name; }
        public void SetType(PokemonType type) => _type = type;
        public void SetHealthPoints(int healthPoints) => _healthPoints = healthPoints;
        public void SetWeakness(PokemonType type) => _weakness = type;
        public void SetOrigin(PokemonRegion region) => _origin = region;
    }

    public interface IPokemonBuilder
    {
        void SetName();
        void SetType();
        void SetHealthPoints();
        void SetWeakness();
        void SetOrigin();

        Pokemon GetPokemon();
    }

    public class BlastoiseBuilder : IPokemonBuilder
    {
        private Pokemon Blastoise = new Pokemon();

        public Pokemon GetPokemon() { return Blastoise; }

        public void SetHealthPoints()
        {
            Blastoise.SetHealthPoints(180);
        }

        public void SetName()
        {
            Blastoise.SetName("Blastoise");
        }

        public void SetOrigin()
        {
            Blastoise.SetOrigin(PokemonRegion.Kanto);
        }

        public void SetType()
        {
            Blastoise.SetType(PokemonType.Water);
        }

        public void SetWeakness()
        {
            Blastoise.SetWeakness(PokemonType.Electric);
        }
    }

    public class IncineroarBuilder : IPokemonBuilder
    {
        private Pokemon Incineroar = new Pokemon();

        public Pokemon GetPokemon() { return Incineroar; }

        public void SetHealthPoints()
        {
            Incineroar.SetHealthPoints(180);
        }

        public void SetName()
        {
            Incineroar.SetName("Incineroar");
        }

        public void SetOrigin()
        {
            Incineroar.SetOrigin(PokemonRegion.Alola);
        }

        public void SetType()
        {
            Incineroar.SetType(PokemonType.Fire);
        }

        public void SetWeakness()
        {
            Incineroar.SetWeakness(PokemonType.Water);
        }
    }

    public class PokemonCreator
    {
        private readonly IPokemonBuilder builder;

        public PokemonCreator(IPokemonBuilder builder)
        {
            this.builder = builder;
        }

        public void CreatePokemon()
        {
            builder.SetHealthPoints();
            builder.SetName();
            builder.SetType();
            builder.SetOrigin();
            builder.SetWeakness();
        }

        public Pokemon GetPokemon() { return builder.GetPokemon(); }
    }
}
