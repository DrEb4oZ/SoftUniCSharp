using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData.Models
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        private const string IncorectValueInput = "{0} cannot be zero or negative.";


        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(IncorectValueInput, nameof(Length)));
                }
                length = value;
            }
        }
        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(IncorectValueInput, nameof(Width)));
                }
                width = value;
            }
        }
        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(IncorectValueInput, nameof(Height)));
                }
                height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * Length * Width + LateralSurfaceArea();
        }

        public double LateralSurfaceArea()
        {
            return 2 * Length * Height + 2 * Width * Height;
        }

        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
