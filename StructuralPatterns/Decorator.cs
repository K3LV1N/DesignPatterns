using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns
{
    public interface IPokemon
    {
        string Name { get; }
        int HealthPoints { get; }
        string PrimaryAttack { get; }
    }

    public abstract class PokemonDecorator : IPokemon
    {
        private IPokemon _pokemon;

        public string Name => _pokemon.Name;

        public int HealthPoints => _pokemon.HealthPoints;

        public string PrimaryAttack => _pokemon.PrimaryAttack;

        public PokemonDecorator(IPokemon pokemon)
        {
            _pokemon = pokemon;
        }
    }

    public class Blastoise : IPokemon
    {
        private readonly string _name;
        private readonly int _healthPoints;
        private readonly string _primaryAttack;

        public string Name => _name;

        public int HealthPoints => _healthPoints;

        public string PrimaryAttack => _primaryAttack;

        public Blastoise()
        {
            _name = "Blastoise";
            _healthPoints = 180;
            _primaryAttack = "Hydro Pump";
        }
    }

    public class MegaBlastoise : PokemonDecorator
    {
        public MegaBlastoise(IPokemon pokemon) : base(pokemon) {}

        public new string Name => $"Mega {base.Name}";
        public new int HealthPoints => base.HealthPoints + 40;
        public new string PrimaryAttack => "Hydro Bombard";
    }
}
