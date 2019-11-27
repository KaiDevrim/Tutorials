using System;

namespace TowerAttack
{
    class Game
    {
        static void Main(string[] args)
        {

            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new [] {
                    new MapLocation(0,2, map),
                    new MapLocation(1,2, map),
                    new MapLocation(2,2, map),
                    new MapLocation(3,2, map),
                    new MapLocation(4,2, map),
                    new MapLocation(5,2, map),
                    new MapLocation(6,2, map),
                    new MapLocation(7,2, map)
                    }
                );

                Invader[] invaders =
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1,3,map)),
                    new Tower(new MapLocation(3,3,map)),
                    new Tower(new MapLocation(5,3,map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

            bool playerWon = level.Play();
                Console.WriteLine("Player " + (playerWon? "won" : "lost"));
                

            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException ex)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception" + ex);
            }

            /*
            //Tower tower = new Tower();
            //int area = map.Width * map.Height;



            Point x = new MapLocation(4, 2);

            Point p = x;

            map.OnMap(new MapLocation(0, 0));

            //bool isOnMap = map.OnMap(point);

            //point = new Point(8, 5);
            //isOnMap = map.OnMap(point);

            Console.WriteLine(x is MapLocation);
            Console.WriteLine(x is Point);

            Point point = new Point(0, 0);
            Console.WriteLine(point is MapLocation);

            Console.WriteLine(x.DistanceTo(5, 5));

            */
        }
    }
}
