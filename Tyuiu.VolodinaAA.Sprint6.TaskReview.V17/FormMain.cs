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

        DataService ds = new DataService();
        
        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            //
        }

        private void buttonPushMatrix_VAA_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBoxColumns_VAA.Text, out int rows) && int.TryParse(textBoxColumns_VAA.Text, out int columns))
            {
                dataGridViewMatrix_VAA.Columns.Clear();
                dataGridViewMatrix_VAA.Rows.Clear();
                dataGridViewMatrix_VAA.RowCount = rows;
                dataGridViewMatrix_VAA.ColumnCount = columns;

                int[,] array = new int[rows, columns];
                Random random = new Random();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = random.Next(Convert.ToInt32(textBoxDiapN1_VAA.Text), Convert.ToInt32(textBoxDiapN2_VAA.Text) + 1);
                        dataGridViewMatrix_VAA.Rows[i].Cells[j].Value = array[i, j];
                        if (j > 1)
                        {
                            array[i, j] = array[i, j - 2] * array[i, j - 1];
                            dataGridViewMatrix_VAA.Rows[i].Cells[j].Value = array[i, j];
                        }
                        dataGridViewMatrix_VAA.Columns[j].Width = 45;
                        dataGridViewMatrix_VAA.Rows[i].Height = 45;
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
            MessageBox.Show("Таск Ревью выполнила студентка группы ПКТб-23-1 Володина Александра Александровна", "Вам пришло новое сообщение", MessageBoxButtons.OK);
        }
    }
}
