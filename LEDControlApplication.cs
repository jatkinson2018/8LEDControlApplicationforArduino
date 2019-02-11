using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _8LEDControlApplication
{
    public partial class LEDControlApplication : Form
    {

        public LEDControlApplication()
        {
            InitializeComponent();
        }


        private void LEDControlApplication_Load(object sender, EventArgs e)
        {
            serialPort1.Open();

        }

        private void RedLED1button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("1");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }

        }

        private void RedLED2button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("2");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void BlueLED1Button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("3");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void BlueLED2Button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("4");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void GreenLED1Button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("5");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void GreenLED2Button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("6");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void YellowLED1Button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("7");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void YellowLED2Button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("8");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void RedLED1ButtonOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("A");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void RedLED2ButtonOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("B");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void BlueLED1ButtonOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("C");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void BlueLED2ButtonOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("D");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void GreenLED1ButtonOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("E");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void GreenLED2ButtonOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("F");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void YellowLED1ButtonOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("G");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void YellowLED2ButtonOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("H");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("0");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }

            this.Close();


        }

        private void AllOnButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("Z");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void AllOffButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("0");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void RedLEDsOn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("a");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void BlueLEDsOn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("b");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void GreenLEDsOn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("c");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void YellowLEDsOn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("d");
            }
            catch (Exception)
            {

                MessageBox.Show("Arduino not connected, please re connect");
            }
        }

        private void LEDBlinkButtonOn_Click(object sender, EventArgs e)
        {
                 

                
                
        }

     
            
        

     
    } 
        
        
        

       
}

