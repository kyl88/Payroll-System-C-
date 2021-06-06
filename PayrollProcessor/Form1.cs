using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessit_Click(object sender, EventArgs e)
        {
            double monday1 = 0.0, tuesday1 = 0.0, wednesday1 = 0.0, thursday1 = 0.0, friday1 = 0.0, saturday1 = 0.0, sunday1 = 0.0,
                monday2 = 0.0, tuesday2 = 0.0, wednesday2 = 0.0, thursday2 = 0.0, friday2 = 0.0, saturday2 = 0.0, sunday2 = 0.0;

                double totalHoursWeek1=0.0, totalHoursWeek2=0.0, ovtHours1=0.0,ovtHours2=0.0,regAmount=0.0,regAmount2=0.0,regHours1=0.0,regHours2=0.0,ovtAmount1=0.0,ovtAmount2=0.0;

                double regularAmount = 0.0, overtimeAmount = 0.0, totalEarnings = 0.0, regularHours = 0.0, overtimeHours = 0.0;


                double hourlySalary = 0.0;

            // retrieve the hourly Salary



                try
                {
                    hourlySalary = double.Parse(this.txtHourlySalary.Text);


                }             

                    catch
                     {


                        MessageBox.Show("The value for hourlySalary is invalid","Please try again");

                        this.txtHourlySalary.Focus();

                     }

                try
                {
                    monday1 = double.Parse(this.txtMonday1.Text);

                }

                catch
                {
                    MessageBox.Show("You entered a invalid value", "Please try again");

                    this.txtMonday1.Focus();

                }

                try
                {
                    tuesday1 = double.Parse(this.txtTuesday1.Text);


                }

                catch
                {
                    MessageBox.Show("You entered a invalid value", "Please try again");

                    this.txtTuesday1.Focus();


                }

                try
                {

                    wednesday1 = double.Parse(this.txtWednesday.Text);

                   


                }

                catch
                {

                    MessageBox.Show("You entered a invalid value", "Please try again ");

                    this.txtWednesday.Focus();
                }

                try
                {
                    thursday1 = double.Parse(this.txtThursday1.Text);


                }
                catch
                {
                    MessageBox.Show("You entered a invalid value", "Please try again");

                    this.txtThursday1.Focus();


                }

                try
                {
                    friday1 = double.Parse(this.txtFriday1.Text);

                }
                catch
                {
                    MessageBox.Show("You entered an invalid value", "Please try again");

                    this.txtFriday1.Focus();


                }

                try
                {
                    saturday1 = double.Parse(this.txtSaturday1.Text);


                }
                catch
                {
                    MessageBox.Show("You entered an invalid value", "Please try again");
                    this.txtSaturday1.Focus();


                }
                try
                {
                    sunday1 = double.Parse(this.txtSunday1.Text);


                }
                catch
                {
                    MessageBox.Show("You entered an invalid value", "Please try again");

                    this.txtSunday1.Focus();


                }

                try
                {
                    monday2 = double.Parse(this.txtMonday2.Text);


                }

                catch
                {
                    MessageBox.Show("You entered a inalid value", "Please try again ");

                    this.txtMonday2.Focus();


                }

                try
                {
                    tuesday2 = double.Parse(this.txtTuesday2.Text);
                }
                catch
                {
                    MessageBox.Show("", "");


                    this.txtTuesday2.Focus();


                }

                try
                {
                    wednesday2 = double.Parse(this.txtWednesday2.Text);

                }

                catch
                {
                    MessageBox.Show("Please enter an invalid one", "Please try again");

                    this.txtWednesday2.Focus();



                }

                try
                {
                    thursday2 = double.Parse(txtThursday2.Text);


                }

                catch
                {
                    MessageBox.Show("You entered an invalid value", "Please try again");

                    this.txtThursday2.Focus();


                }

                try
                {
                    friday2 = double.Parse(txtFriday2.Text);


                }

                catch
                {
                    MessageBox.Show("You entered an invalid value", "Please try again");

                    this.txtFriday2.Focus();

                }

                try
                {
                    saturday2 = double.Parse(txtSaturday2.Text);
                }

                catch
                {
                    MessageBox.Show("You entered an invalid value", "Please try again");
                    this.txtSaturday2.Focus();


                }

                try
                {
                    sunday2 = double.Parse(txtSunday2.Text);

                }

                catch
                {
                    MessageBox.Show("You entered an invalid value", "Please try again");
                    this.txtSunday2.Focus();


                }
                
            // Calculate the total number of hours for each hour

                totalHoursWeek1 = monday1 + tuesday1 + wednesday1 + thursday1 + friday1 + saturday1 + sunday1;

                totalHoursWeek2 = monday2 + tuesday2 + wednesday2 + thursday2 + friday2 + saturday2 + sunday2;

            // overtime formula

                double ovtSalary = hourlySalary * 1.5;

            // if the employee worked under 40 hours, there is no overtime

                if (totalHoursWeek1 < 40)
                {  

                    regHours1 = totalHoursWeek1;
                    regAmount = hourlySalary * regHours1;

                    ovtHours1 = 0.0;
                    ovtAmount1 = 0.0;

         
 
                    
                }

            // If the employee worked over 40 hours, Calculate the overtime

                else if(totalHoursWeek1>40)
                {
                    regHours1 = 40;
                    regAmount = hourlySalary * 40;
                    ovtHours1 = totalHoursWeek1 - 40;

                    ovtAmount1 = ovtHours1 * ovtSalary;



                }

                if (totalHoursWeek2 < 40)
                {
                    regHours2 = totalHoursWeek2;
                    regAmount2 = hourlySalary * regHours2;
                    ovtHours2 = 0.0;
                    ovtAmount2 = 0.0;


                }

                else if (totalHoursWeek2>40)
                {

                    regHours2 = 40;
                    regAmount2 = hourlySalary * 40;
                    ovtHours2 = totalHoursWeek2 - 40;
                    ovtAmount2 = ovtHours2 * ovtSalary;



                }
               
            
            regularHours= regHours1 + regHours2;
            overtimeHours = ovtHours1 + ovtHours2;
            regularAmount = regAmount + regAmount2;
            overtimeAmount = ovtAmount1 + ovtAmount2;
            totalEarnings = regularAmount + overtimeAmount;

            this.txtRegularHours.Text = regularHours.ToString("F");
            this.txtOvertimeHours.Text = overtimeHours.ToString("F");
            this.txtRegularAmount.Text = regularAmount.ToString("F");
            this.txtTotalEarnings.Text = totalEarnings.ToString("F");
            this.txtOvertimeAmount.Text = overtimeAmount.ToString("F");




            

        }

        private void txtThursday1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            var today = DateTime.Today;

            Console.WriteLine(now);

            Console.WriteLine(today);


        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            var today = DateTime.Today;

            Console.WriteLine(now);

            Console.WriteLine(today);

            
        }
    }
}
