using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Practice01.Wind;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practice01
{
    public partial class Form2 : Form
    { 
        private MyArray<Wind> windArray;
        private Random _rnd; // Оголошення Random
        public Form2()
        {
            InitializeComponent();
            windArray = new MyArray<Wind>();
            _rnd = new Random(); // Ініціалізація Random
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int size = (int)nudN.Value;

                windArray = new MyArray<Wind>(size);

                dataGridView1.Rows.Clear();

                for (int i = 0; i < windArray.Count; i++)
                {
                    Wind newWind = new Wind((WindDirection)_rnd.Next((int)WindDirection.North, (int)WindDirection.East + 1),
                        Math.Round(_rnd.Next(20) + _rnd.NextDouble(), 2));

                    windArray[i] = newWind;
                    dataGridView1.Rows.Add(newWind.ToString());
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (windArray.Count > 0)
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
        }
        private int GetCalculate(MyArray<Wind> array)
        {
            int count = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i].Direction == WindDirection.South && array[i].Power > 8d)
                {
                    count++;
                }
            }
            return count;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void nudN_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

   
    

  