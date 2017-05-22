using System;
using System.Collections.Generic;
using System.Windows.Forms;

using GeometricsFigure;

namespace GeometricsFigureView
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private static List<IFigure> _figures;

        public MainForm()
        {
            InitializeComponent();
            _figures = new List<IFigure>();
            iFigureBindingSource.DataSource = _figures;
        }

        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            if ( form.ShowDialog() == DialogResult.OK )
            {
                iFigureBindingSource.Add(form.Figure);
            }
        }

        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            if ( iFigureBindingSource.Current != null )
            {
                foreach (DataGridViewRow r in FigureDataGridView.SelectedRows)
                {
                    iFigureBindingSource.RemoveAt(r.Index);
                }
            }
            else
            {
                MessageBox.Show(@"Вы не выбрали строку, которую хотите удалить.", @"Ошибка!");
            }
        }

        private void ModifyFigureButton_Click(object sender, EventArgs e)
        {
            if ( iFigureBindingSource.Current == null)
            {
                MessageBox.Show(@"Вы не выбрали строку, которую хотите изменить.", @"Ошибка!");
            }
            else
            {
                var index = FigureDataGridView.SelectedCells[0].RowIndex;
                var form = new AddForm
                           {
                               Figure = _figures[index]
                           };
                if ( form.ShowDialog() == DialogResult.OK )
                {
                    iFigureBindingSource.RemoveAt(index);
                    iFigureBindingSource.Insert(index, form.Figure);
                }
            }
        }

        private void RandomFigureButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            iFigureBindingSource.Add(new GeometricsFigure.Rectangle(rnd.Next(1,30), rnd.Next(1,30)));
            int a = rnd.Next(1, 20);
            int b = rnd.Next(1, 20);
            int c = rnd.Next(a+b,a+b);
            iFigureBindingSource.Add(new Triangle(a, b, c));
            iFigureBindingSource.Add(new Square(rnd.Next(1, 20)));
            iFigureBindingSource.Add(new Circle(rnd.Next(1, 10)));
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if ( !(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel) )
            {
                _figures = Serialization.Deserialize(ofd.FileName);
                iFigureBindingSource.DataSource = _figures;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_figures.Count != 0)
            {
                var ofd = new SaveFileDialog
                {
                    Filter = @"clv files (*.clv)|*.clv",
                    RestoreDirectory = true
                };
                if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                {
                    Serialization.Serialize(ofd.FileName, _figures);
                }
            }
            else
            {
                MessageBox.Show(@"Ошибка. Файл не може быть пустым");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != string.Empty)
            {
                for (var i = 0; i < FigureDataGridView.RowCount; i++)
                {
                    FigureDataGridView.Rows[i].Selected = false;
                    for (var j = 0; j < FigureDataGridView.ColumnCount; j++)
                    {
                        if (FigureDataGridView.Rows[i].Cells[j].Value == null)
                        {
                            continue;
                        }
                        if (!FigureDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchTextBox.Text.ToLower()))
                        {
                            continue;
                        }
                        FigureDataGridView.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Введите значение поиска", @"Ошибка!");
            }
        }



        private void CreateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _figures = new List<IFigure>();
            iFigureBindingSource.DataSource = _figures;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
