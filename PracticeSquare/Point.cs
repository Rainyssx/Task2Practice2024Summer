using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSquare
{
    internal class Point
    {
        private double _xcoordinate;
        private double _ycoordinate;
        private double _zcoordinate;

       
        public double X => _xcoordinate;
        public double Y => _ycoordinate;
        public double Z => _zcoordinate;

        public Point nullPoint = new Point(0, 0, 0);

        public Point(double xcoordinate, double ycoordinate, double zcoordinate)
        {
            _xcoordinate = xcoordinate;
            _ycoordinate = ycoordinate;
            _zcoordinate = zcoordinate;
        }

       public bool Equivalent( Point b)
        {
            return this.X == b.X && this.Y == b.Y && this.Z == b.Z;
        }
        
    }
}
