using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSquare
{
    internal class Vector
    {
        private double _xcoordinate;
        private double _ycoordinate;
        private double _zcoordinate;

        public double X => _xcoordinate;
        public double Y => _ycoordinate;
        public double Z => _zcoordinate;

        public Vector()
        {
            _xcoordinate = 0;
            _ycoordinate = 0;
            _zcoordinate = 0; 

        }

        public Vector(double x, double y, double z)
        {
            _xcoordinate = x;
            _ycoordinate = y;
            _zcoordinate = z;
        }
        public Vector(Point a, Point b) =>
         new Vector(b.X - a.X, b.X - a.X, b.X - a.X);

        public Vector(Plane a)
        {
            _xcoordinate = a.ACoefficient;
            _ycoordinate = a.BCoefficient;
            _zcoordinate = a.CCoefficient;
        }

        public Vector CrossProduct(Vector b)
        {
            double x, y, z;
            x = this.Y * b.Z - b.Y * this.Z;
            y = (this.X * b.Z - b.X * this.Z) * -1;
            z = this.X * b.Y - b.X * this.Y;

            var rtnvector = new Vector(x, y, z);

            return rtnvector;
        }

        public double DotProduct(Vector b)
        {
            return this.X * b.X + this.Y * b.Y + this.Z * b.Z;
        }

        public double Module()
        {
            return (double)Math.Sqrt(this.X * this.X + this.Y * this.Y  + this.Z * this.Z);
        }
        public bool Equivalent(Vector b)
        {
            return this.X == b.X && this.Y == b.Y && this.Z == b.Z;
        }

    }
}
