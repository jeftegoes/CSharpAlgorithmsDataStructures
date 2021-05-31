using System;
using System.Collections.Generic;

namespace Business
{
    public enum Type
    {
        Elf,
        Ork
    }

    public class Character : IDisposable
    {
        public string Name { get; set; }
        public Type Type { get; }
        private double speed;
        private int _damage;
        public bool IsDead { get; set; }
        public int Armor { get; set; } = 50;

        public List<string> Weaponry { get; set; } = new List<string>();
        public double Speed
        {
            get
            {
                switch (Type)
                {
                    case Type.Elf:
                        return 1.7;
                    case Type.Ork:
                        return 1.4;
                    default:
                        return 0;
                }
            }
            set
            {
                speed = value;
            }
        }
        public int Health { get; private set; } = 145;

        public Character(Type type)
        {
            Type = type;
        }

        public Character(Type type, string name)
        {
            Name = name;
            Type = type;
        }

        public void Damage(int damage)
        {
            if (damage > 1000)
                throw new ArgumentOutOfRangeException();

            _damage = damage;

            IsDead = damage >= 500;

            Health -= damage;
        }

        public void Dispose()
        {

        }
    }
}