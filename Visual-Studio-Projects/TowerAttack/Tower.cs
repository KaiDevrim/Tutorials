using System;

namespace TowerAttack
{
	class Tower
	{
        private readonly MapLocation _location;
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;
        private static readonly Random _random = new Random();
        public Tower(MapLocation location)
        {
            _location = location;
        }
        public bool IsSuccesfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {

            foreach(Invader invader in invaders)
            {
               
                if(invader.IsActive &&_location.InRangeOf(invader.Location, _range))
                {
                    if(IsSuccesfulShot()) {
                        invader.DecreaseHealth(_power);
                    }
                    break;
                }
                
            }
        }

	}
}
