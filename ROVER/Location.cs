using System;
using System.Collections.Generic;
using System.Text;

namespace ROVER
{   public enum Direction
    {                 //Reference value is defined for directions.
        N=1,
        E=2,
        S=3,
        W=4
    } 
    public interface ILocation
    {
        void Start(List<int> edgepoint, string orders);
    }
    public class Location : ILocation
    {
        public void Start(List<int> edgepoint, string orders)
        {
            foreach (var order in orders)
            {
                switch (order)
                {
                    case 'M':
                        this.SameDirection();
                        break;
                    case 'L':
                        this.Left();
                        break;                      //Movement orders have been defined.
                    case 'R':
                        this.Right();
                        break;
                    default:
                        Console.WriteLine($"You entired wrong {order}");
                        break;
                }

                if (this.X < 0 || this.X > edgepoint[0] || this.Y < 0 || this.Y > edgepoint[1])
                {
                    throw new Exception($"You entered a value outside the planet's boundary.");
                }
            }
        }

        public int X { get; set; }
        public int Y { get; set; }

        public Direction Direction { get; set; }

        public Location()
        {
            X = Y = 0;                           //the lower-left coordinates are assumed to be 0, 0.
            Direction = Direction.N;
        }

        private void Left()
        {
            if (this.Direction == Direction.N) { this.Direction = Direction.W; }
            else if (this.Direction == Direction.S) { this.Direction = Direction.E; }
            else if (this.Direction == Direction.E) { this.Direction = Direction.N; }
            else if (this.Direction == Direction.W) { this.Direction = Direction.S; }
            
        }

        private void Right()
        {
            if (this.Direction == Direction.N) { this.Direction = Direction.E; }
            else if (this.Direction == Direction.S) { this.Direction = Direction.W; }
            else if (this.Direction == Direction.E) { this.Direction = Direction.S; }
            else if (this.Direction == Direction.W) { this.Direction = Direction.N; }
        }

        private void SameDirection()
        {
            if (this.Direction == Direction.N) { this.Y += 1; }
            else if (this.Direction == Direction.S) { this.Y -=1; }
            else if (this.Direction == Direction.E) { this.X += 1; }
            else if (this.Direction == Direction.W) { this.X -= 1; }
        }


    }
}
         