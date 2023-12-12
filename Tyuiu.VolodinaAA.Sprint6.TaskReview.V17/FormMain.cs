using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolodinaAA.Sprint6.TaskReview.V17.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.TaskReview.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int n;
        static int m;
        DataService ds = new DataService();
        
        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            //
        }

        private void buttonPushMatrix_VAA_Click(object sender, EventArgs e)
        {
            int[,] array;
            if (int.TryParse(textBoxColumns_VAA.Text, out int rows) && int.TryParse(textBoxColumns_VAA.Text, out int columns))
            {
                dataGridViewMatrix_VAA.Columns.Clear();
                dataGridViewMatrix_VAA.RowCount = rows;
                dataGridViewMatrix_VAA.ColumnCount = columns;

                array = new int[rows, columns];
                Random random = new Random();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix_VAA.Rows[i].Cells[j].Value = random.Next(Convert.ToInt32(textBoxDiapN1_VAA.Text), Convert.ToInt32(textBoxDiapN2_VAA.Text));
                        dataGridViewMatrix_VAA.Columns[i].Width = 55;
                        dataGridViewMatrix_VAA.Rows[i].Height = 55;

                        array[i, j] = Convert.ToInt32(dataGridViewMatrix_VAA.Rows[i].Cells[j].Value);
                    }
                }
                DataService ds = new DataService();
                try
                {
                    textBoxResult_VAA.Text = Convert.ToString(ds.GetMatrix(array, Convert.ToInt32(textBoxDiapN1_VAA.Text),
                        Convert.ToInt32(textBoxDiapN2_VAA.Text), Convert.ToInt32(textBoxValueC_VAA.Text), Convert.ToInt32(textBoxValueK_VAA.Text),
                        Convert.ToInt32(textBoxValueL_VAA.Text)));
                }
                catch
                {
                    MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonInfo_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск Ревью вывополнила студентка группы ПКТб-23-1 Володина Александра Александровна", "Вам пришло новое сообщение", MessageBoxButtons.OK);
        }
    }
}
