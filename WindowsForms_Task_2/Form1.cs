using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace WindowsForms_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string Speed = boat.Text;
            string CourseSpeed = course.Text;
            string time1 = lake.Text;
            string time2 = river.Text;

            double s, cs, t1, t2;
            
            if (!double.TryParse(Speed, out s) || !double.TryParse(CourseSpeed, out cs) || 
                !double.TryParse(time1, out t1) || !double.TryParse(time2, out t2))
            {
                MessageBox.Show("Неверные данные!");
            }
            else
            {
                
                if (s <= 0 || cs <= 0 || t1 <= 0 || t2 <= 0)
                {
                    MessageBox.Show("Введены отрицательные или нулевые значения!");
                    return;
                }
                
                var b = new Log();
                result.Text = b.findDistance(s, cs, t1, t2).ToString();
            }
        }
    }
}