using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualSORT
{
    internal class MyInt : ISortable
    {
        public int value;

        public MyInt(int value)
        {
            this.value = value;
        }

        public int CompareTo(object x)
        {
            if (x is MyInt == false)
            {
                throw new Exception("Is not MyInt type");
            }

            MyInt xx = (MyInt)x;
            return value - xx.value;
        }

        // преобразование строки в тип MyINt
        public static MyInt ToMyInt(string str)
        {
            int x = Int32.Parse(str);
            return new MyInt(x);
        }

        public static MyInt ToMyInt(int value)
        {
            return new MyInt(value);
        }

        public static int ToInt(MyInt x)
        {
            return x.value;
        }

        public Color GetColor(ISortable min, ISortable max)
        {
            MyInt xMin = (MyInt)min;
            MyInt xMax = (MyInt)max;

            int difference = xMax.value - xMin.value;

            if (difference == 0)
            {
                return Color.Black;
            }

            int whenRed = xMin.value;
            int whenYellow = (difference / 5) + whenRed;
            int whenGreen = (difference / 5) + whenYellow;
            int whenTeal = (difference / 5) + whenGreen;
            int whenBlue = (difference / 5) + whenTeal;
            int whenPurple = xMax.value;

            int red;
            int green;
            int blue;

            if (value >= whenRed && value < whenYellow)
            {
                red = 255;
                green = (256 * (value - whenRed)) / (whenYellow - whenRed);
                blue = 0;

                return Color.FromArgb(red, green, blue);
            }

            if (value >= whenYellow && value < whenGreen)
            {
                red = 255 - ((256 * (value - whenYellow)) / (whenGreen - whenYellow));
                green = 255;
                blue = 0;

                return Color.FromArgb(red, green, blue);
            }

            if (value >= whenGreen && value < whenTeal)
            {
                red = 0;
                green = 255;
                blue = (256 * (value - whenGreen)) / (whenTeal - whenGreen);

                return Color.FromArgb(red, green, blue);
            }

            if (value >= whenTeal && value < whenBlue)
            {
                red = 0;
                green = 255 - ((256 * (value - whenTeal)) / (whenBlue - whenTeal));
                blue = 255;

                return Color.FromArgb(red, green, blue);
            }

            if (value >= whenBlue && value < whenPurple)
            {
                red = (256 * (value - whenBlue)) / (whenPurple - whenBlue);
                green = 0;
                blue = 255;

                return Color.FromArgb(red, green, blue);
            }

            return Color.FromArgb(255, 0, 255);
        }
    }
}
