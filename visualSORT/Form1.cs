using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualSORT
{
    public partial class Form1 : Form
    {
        Graphics canvas;
        Graphics canvasSort;
        Sorter sorter;

        ISortable[] array;
        ISortable min;
        ISortable max;

        MyInt minn;
        MyInt maxx;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            canvas = panel1.CreateGraphics();
            canvasSort = panel2.CreateGraphics();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonListGenerate_Click(object sender, EventArgs e)
        {
            canvas.Clear(Color.White);

            array = new ISortable[Int32.Parse(textBoxArrayLength.Text)];
            minn = MyInt.ToMyInt(textBoxMinValue.Text);
            maxx = MyInt.ToMyInt(textBoxMaxValue.Text);

            min = minn;
            max = maxx;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = MyInt.ToMyInt(random.Next(MyInt.ToInt(minn), MyInt.ToInt(maxx)));
            }

            sorter = new Sorter(array);
            sorter.Draw(canvas);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            canvasSort.Clear(Color.White);
            sorter.Sort(canvasSort);
        }
    }
}
