using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kharyushin_ISP01_02
{
    class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Length()
        {
            return Math.Sqrt((Math.Pow(this.X, 2)) + Math.Pow(this.Y, 2) + Math.Pow(this.Z, 2));
        }

        public double ScalarProductVectors(Vector3D other)
        {
            return (this.X * other.X) + (this.Y * other.Y) + (this.Z * other.Z);
        }

        public Vector3D VectorsProduct(Vector3D other)
        {
            return new Vector3D ( (this.Y * other.Z) - (this.Z * other.Y),
                (this.Z * other.X) - (this.X * other.Z),
                (this.X * other.Y) - (this.Y * other.X) );
        }

        public override string ToString()
        {
            return $"vec (x:{X} ; y:{Y} ; z:{Z})";
        }
    }
}
