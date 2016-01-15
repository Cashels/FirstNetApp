using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Vickypedia.AgeCalc
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        AgeCalculator calculator;
        private void Form1_Load(object sender, EventArgs e)
        {
            calculator = new AgeCalculator(DateTime.Now.Date, DateTime.Now);
            calculator.Recalculated += new EventHandler(calculator_Recalculated);
            bsAgeCalculator.DataSource = calculator;

            calculator.Recalc();
            timer1.Enabled = true;
        }

        void calculator_Recalculated(object sender, EventArgs e)
        {
            lblYears.Text = String.Format("<b>{0:n0}</b> years", calculator.Years);
            lblMonths.Text = String.Format("<b>{0:n0}</b> months", calculator.Months);
            lblDays.Text = String.Format("<b>{0:n0}</b> days", calculator.Days);
            lblHours.Text = String.Format("<b>{0:n0}</b> hours", calculator.Hours);
            lblMinutes.Text = String.Format("<b>{0:n0}</b> minutes", calculator.Minutes);
            lblSeconds.Text = String.Format("<b>{0:n0}</b> seconds", calculator.Seconds);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            calculator.CompareDate = DateTime.Now;
            //calculator.Recalc();
        }

    }
}
