using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private MathInterpreter interpreter;
        public Form1()
        {
            InitializeComponent();
            interpreter = new MathInterpreter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void evaluate_Click(object sender, EventArgs e)
        {
            string expression = inputExpression.Text;
            if (interpreter.ValidateExpression(expression))
            {
                double result = interpreter.EvaluateExpression(expression);
                outputExpression.Text = result.ToString();
            }
            else
            {
                outputExpression.Text = "Invalid Expression";
            }
        }

        private void draw_Click(object sender, EventArgs e)
        {
            if (double.TryParse(slopetxt.Text, out double slope) &&
                double.TryParse(intercepttxt.Text, out double intercept))
            {
                int canvasWidth = 500; // Adjust canvas dimensions as needed
                int canvasHeight = 500;

                Bitmap lineBitmap = DrawLineOnCanvas(slope, intercept, canvasWidth, canvasHeight);

                // Assuming you have an Image control named 'pictureBox' on your form
                pictureBox.Image = lineBitmap;
            }
            else
            {
                MessageBox.Show("Invalid slope or intercept.");
            }
        }

        private Bitmap DrawLineOnCanvas(double slope, double intercept, int canvasWidth, int canvasHeight)
        {
            Bitmap canvas = new Bitmap(canvasWidth, canvasHeight);

            using (Graphics graphics = Graphics.FromImage(canvas))
            {
                Pen linePen = new Pen(Color.Blue, 2);

                // Convert slope and intercept to coordinates
                int startX = 0;
                int startY = (int)(intercept);
                int endX = canvasWidth - 1;
                int endY = (int)(slope * endX + intercept);

                graphics.DrawLine(linePen, startX, startY, endX, endY);
            }

            return canvas;
        }







        private class MathInterpreter
        {
            public double EvaluateExpression(string expression)
            {
                using DataTable dataTable = new DataTable();
                return Convert.ToDouble(dataTable.Compute(expression, ""));
            }

            public bool ValidateExpression(string expression)
            {
                // Regular expression to validate tokens
                string pattern = @"^(\d{1,3}(\.\d{1,2})?|\+|\-|x|\*|/|\(|\))+$";
                return Regex.IsMatch(expression, pattern);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}