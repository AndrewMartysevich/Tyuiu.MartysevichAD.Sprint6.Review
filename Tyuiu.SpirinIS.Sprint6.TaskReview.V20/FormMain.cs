using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MartysevichAD.Sprint6.TaskReview.V20.Lib;

namespace Tyuiu.Martysevich.Sprint6.TaskReview.V20
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxStr_MAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDo_MAD_Click(object sender, EventArgs e)
        {
            textBoxRes_MAD.Text = null;
            int rows = Convert.ToInt32(textBoxRowIn_MAD.Text);
            int columns = Convert.ToInt32(textBoxColumnIn_MAD.Text);
            int n1 = Convert.ToInt32(textBoxStartIn_MAD.Text);
            int n2 = Convert.ToInt32(textBoxFinishIn_MAD.Text);
            int[,] mtrx = new int [rows, columns];
            Random rnd = new Random();
            
            dataGridView_MAD.ColumnCount = columns;
            dataGridView_MAD.RowCount = rows;
            int[] arr = new int[columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j % 2 == 0)
                    {

                        mtrx[i, j] = rnd.Next(n1, n2);
                    }
                    else
                    {
                        mtrx[i, j] = mtrx[i, j - 1] * mtrx[i, j - 1] * mtrx[i, j - 1];
                    }
                }
            }
            for (int i = 0; i < rows-1; i++)
            {
                dataGridView_MAD.Columns[i].Width = 50;
            }
            
           


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_MAD.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

            int k = Convert.ToInt32(textBoxK_MAD.Text);
            int l = Convert.ToInt32(textBoxL_MAD.Text);
            int r = Convert.ToInt32(textBoxSelectedRow_MAD.Text);

            textBoxRes_MAD.Text = Convert.ToString(ds.GetMatrix(mtrx,n1,n2,r,k,l));
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRowIn_MAD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
