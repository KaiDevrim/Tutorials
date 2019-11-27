using System;

namespace TowerAttack
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public int Health { get; set; } = 2;

        public bool HasScored { get { return _pathStep >= _path.Length;  } }

        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized || HasScored);
       

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += 1;

        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
        
    }
}
