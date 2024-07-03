using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSquare
{
    internal class Plane
    {
        private double _aCoefficient;
        private double _bCoefficient;
        private double _cCoefficient;
        private double _dCoefficient;

        public double ACoefficient => _aCoefficient;
        public double BCoefficient => _bCoefficient;
        public double CCoefficient => _cCoefficient;
        public double DCoefficient => _dCoefficient;

        public Plane (double aCoefficient, double bCoefficient, double cCoefficient, double dCoefficient)
        {
            _aCoefficient = aCoefficient;
            _bCoefficient = bCoefficient;
            _cCoefficient = cCoefficient;
            _dCoefficient = dCoefficient;
        }

       

        public double AngleLineAndPlane ( Line line)
        {
            Vector Vec1 = new Vector(this);
            Vector Vec2 = line.GetVectorLine();
            var x = Math.Abs(Vec1.DotProduct(Vec2)) / (Vec1.Module() * Vec2.Module());
            return Math.Acos(x) * 180 / Math.PI;
        }


    }
}
