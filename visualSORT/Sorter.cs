using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualSORT
{
    internal class Sorter
    {
        ISortable[] array;
        ISortable min;
        ISortable max;

        public Sorter(ISortable[] array)
        {
            if (array != null)
            {
                if(array.Length != 0)
                {
                    this.array = array;
                    min = max = array[0];

                    foreach (ISortable x in array)
                    {
                        if (x.CompareTo(max) > 0) max = x;
                        if (x.CompareTo(min) < 0) min = x;
                    }
                }
            }
        }

        public void Sort(Graphics canvas)
        {
            if (array == null || array.Length <= 1)
                return;

            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        ISortable temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        Draw(canvas);
                        System.Threading.Thread.Sleep(25);
                    }
                }
            }
        }

        public void Draw(Graphics canvas)
        {
            for (int i = 0; i < array.Length; i++)
            {
                canvas.FillRectangle(new SolidBrush(array[i].GetColor(min, max)), i * 10, 0, 10, 200);
            }
        }

        //public Color GetColor(ISortable x)
        //{

        //    if (min < 0 && max >= 0)
        //    {
        //        max += Math.Abs(min);
        //        min = 0;
        //    }

        //    else if (min < 0 && max < 0)
        //    {
        //        int tmp = min;
        //        min = Math.Abs(max);
        //        max = Math.Abs(tmp);
        //    }

        //    int difference = max - min;

        //    if (difference == 0)
        //    {
        //        return Color.Black;
        //    }

        //    int whenRed = min;
        //    int whenYellow = (difference / 5) + whenRed;
        //    int whenGreen = (difference / 5) + whenYellow;
        //    int whenTeal = (difference / 5) + whenGreen;
        //    int whenBlue = (difference / 5) + whenTeal;
        //    int whenPurple = max;

        //    int red;
        //    int green;
        //    int blue;

        //    if (x >= whenRed && x < whenYellow)
        //    {
        //        red = 255;
        //        green = (256 * (x - whenRed)) / (whenYellow - whenRed);
        //        blue = 0;

        //        return Color.FromArgb(red, green, blue);
        //    }

        //    if (x >= whenYellow && x < whenGreen)
        //    {
        //        red = 255 - ((256 * (x - whenYellow)) / (whenGreen - whenYellow));
        //        green = 255;
        //        blue = 0;

        //        return Color.FromArgb(red, green, blue);
        //    }

        //    if (x >= whenGreen && x < whenTeal)
        //    {
        //        red = 0;
        //        green = 255;
        //        blue = (256 * (x - whenGreen)) / (whenTeal - whenGreen);

        //        return Color.FromArgb(red, green, blue);
        //    }

        //    if (x >= whenTeal && x < whenBlue)
        //    {
        //        red = 0;
        //        green = 255 - ((256 * (x - whenTeal)) / (whenBlue - whenTeal));
        //        blue = 255;

        //        return Color.FromArgb(red, green, blue);
        //    }

        //    if (x >= whenBlue && x < whenPurple)
        //    {
        //        red = (256 * (x - whenBlue)) / (whenPurple - whenBlue);
        //        green = 0;
        //        blue = 255;

        //        return Color.FromArgb(red, green, blue);
        //    }

        //    return Color.FromArgb(255, 0, 255);
        //}
    }
}
