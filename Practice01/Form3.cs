using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice01
{
    public partial class Form3 : Form
    {
        private Array2D<Wind> windArray;
        private Random _rnd; // Оголошення Random

        public Form3()
        {
            InitializeComponent();
            windArray = new Array2D<Wind>();
            _rnd = new Random(); // Ініціалізація Random
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sizeA = (int)nudN.Value;
            

            windArray = new Array2D<Wind>(sizeA);

            dataGridView1.Rows.Clear();

            for (int i = 0; i < windArray.LengthA; i++)
            {
                for (int j = 0; j < windArray.LengthB; j++)
                {
                    Wind newWind = new Wind((WindDirection)_rnd.Next((int)WindDirection.North, (int)WindDirection.East + 1),
                        Math.Round(_rnd.Next(20) + _rnd.NextDouble(), 2));

                    windArray[i, j] = newWind;
                    dataGridView1.Rows.Add(newWind.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (windArray.LengthA > 0 && windArray.LengthB > 0)
            {
                int count = GetCalculate(windArray);
                MessageBox.Show($"Кількість днів, коли дув південний вітер із силою більше 8 м/c: {count}",
                    "Результат!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Масив не заповнений! Заповніть масив перед розрахунком!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCalculate(Array2D<Wind> array)
        {
            int count = 0;
            for (int i = 0; i < array.LengthA; i++)
            {
                for (int j = 0; j < array.LengthB; j++)
                {
                    if (array[i, j].Direction == WindDirection.South && array[i, j].Power > 8d)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudN_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
