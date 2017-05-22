using System;
using System.Globalization;
using System.Windows.Forms;
using GeometricsFigure;

namespace GeometricsFigureView
{
    public partial class AddForm : Form
    {
        private IFigure _figure;
        /// <summary>
        /// 
        /// </summary>
        public IFigure Figure
        {
            get
            {
                if (FigureComboBox.SelectedIndex == 0)
                {
                    var rectangle = new Rectangle
                    {
                        Height = Convert.ToDouble(SideATextBox.Text),
                        Width = Convert.ToDouble(SideBTextBox.Text)
                    };
                    _figure = rectangle;
                }
                else if (FigureComboBox.SelectedIndex == 1)
                {
                    var triangle = new Triangle();
                    triangle.SetSides(Convert.ToDouble(SideATextBox.Text),
                        Convert.ToDouble(SideBTextBox.Text),
                        Convert.ToDouble(SideCTextBox.Text));
                    _figure = triangle;
                }
                else if (FigureComboBox.SelectedIndex == 2)
                {
                    var square = new Square
                    {
                        SideA = Convert.ToDouble(SideATextBox.Text)
                    };
                    _figure = square;
                }
                else if (FigureComboBox.SelectedIndex == 3)
                {
                    var circle = new Circle
                    {
                        Radius = Convert.ToDouble(RadiusTextBox.Text)
                    };
                    _figure = circle;
                }
                return _figure;
            }

            set
            {
                if (value is Rectangle)
                {
                    var rec = (Rectangle) value;
                    FigureComboBox.SelectedIndex = 0;
                    FigureComboBox.Enabled = false;
                    SideATextBox.Text = rec.Height.ToString(CultureInfo.InvariantCulture);
                    SideBTextBox.Text = rec.Width.ToString(CultureInfo.InvariantCulture);
                }

                else if (value is Triangle)
                {
                    var rec = (Triangle) value;
                    FigureComboBox.SelectedIndex = 1;
                    FigureComboBox.Enabled = false;
                    SideATextBox.Text = rec.SideA.ToString(CultureInfo.InvariantCulture);
                    SideBTextBox.Text = rec.SideB.ToString(CultureInfo.InvariantCulture);
                    SideCTextBox.Text = rec.SideC.ToString(CultureInfo.InvariantCulture);
                }

                else if (value is Square)
                {
                    var squ = (Square) value;
                    FigureComboBox.SelectedIndex = 2;
                    FigureComboBox.Enabled = false;
                    SideATextBox.Text = squ.SideA.ToString(CultureInfo.InvariantCulture);
                }

                else if (value is Circle)
                {
                    var cir = (Circle) value;
                    FigureComboBox.SelectedIndex = 3;
                    FigureComboBox.Enabled = false;
                    RadiusTextBox.Text = cir.Radius.ToString(CultureInfo.InvariantCulture);
                }
            }
        }


        public AddForm()
        {
            InitializeComponent();
        }

        private void FigureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FigureComboBox.SelectedIndex == 0)
            {
                SideATextBox.Visible = true;
                SideBTextBox.Visible = true;
                SideCTextBox.Visible = false;
                SideDTextBox.Visible = false;
                HeightTextBox.Visible = false;
                RadiusTextBox.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }

            else if (FigureComboBox.SelectedIndex == 1)
            {
                SideATextBox.Visible = true;
                SideBTextBox.Visible = true;
                SideCTextBox.Visible = true;
                SideDTextBox.Visible = false;
                HeightTextBox.Visible = false;
                RadiusTextBox.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }

            else if (FigureComboBox.SelectedIndex == 2)
            {
                SideATextBox.Visible = true;
                SideBTextBox.Visible = false;
                SideCTextBox.Visible = false;
                SideDTextBox.Visible = false;
                HeightTextBox.Visible = false;
                RadiusTextBox.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }

            else if (FigureComboBox.SelectedIndex == 3)
            {
                SideATextBox.Visible = false;
                SideBTextBox.Visible = false;
                SideCTextBox.Visible = false;
                SideDTextBox.Visible = false;
                HeightTextBox.Visible = false;
                RadiusTextBox.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (SideATextBox.TextLength == 0 || SideBTextBox.TextLength == 0 || SideCTextBox.TextLength == 0 
                || RadiusTextBox.TextAlign==0 || SideDTextBox.TextAlign == 0)
            {
                MessageBox.Show(@"Вы не ввели все данные.", @"Ошибка!");
                return;
            }
            if (FigureComboBox.SelectedIndex == -1)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
