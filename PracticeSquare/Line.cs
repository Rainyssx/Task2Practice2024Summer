using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSquare
{
    internal class Line
    {
        private Plane _plane1;
        private Plane _plane2;



        public Plane Plain1 => _plane1;
        public Plane Plane2 => _plane2;
        
        public Vector GetVectorLine()
        {
            Vector vector1 = new Vector(_plane1.ACoefficient, _plane1.BCoefficient, _plane1.CCoefficient);
            Vector vector2 = new Vector(_plane2.ACoefficient, _plane2.BCoefficient, _plane2.CCoefficient);
            return vector1.CrossProduct(vector2);
        }

        public Line(Plane a, Plane b)
        {
            _plane1 = a; _plane2 = b;
        }



    }
}
