using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadSerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Serial s = new Serial();
        private void Form1_Load(object sender, EventArgs e)
        {
      
            var ports = s.getPorts();
            foreach(string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            if(ports.Length > 0)
            {
                comboBox1.SelectedItem = ports[0];
            }
        }

        public string myMethod(string read)
        {
            
                if (read.StartsWith("GasValue:"))
                {
                    string gas = read.Substring(read.IndexOf(" ")).Trim();
                    this.Invoke(new MethodInvoker(delegate {
                        textBox1.Text = gas;
                    }));

                }
            

            return "";
        }
        public string myMethod2(string read)
        {
            if (read.StartsWith("lightLevel:"))
            {
                string ldr = read.Substring(read.IndexOf(" ")).Trim();
                this.Invoke(new MethodInvoker(delegate {
                    textBox2.Text = ldr;
                }));

            }

            return "";
        }
        public string myMethod3(string read)
        {
            if (read.StartsWith("Humidity:"))
            {
                string temp = read.Substring(read.IndexOf("Temperature: ")).Trim();
                this.Invoke(new MethodInvoker(delegate {
                    textBox3.Text = temp;
                }));

            }

            return "";
        }
        public string myMethod4(string read)
        {
            if (read.StartsWith("Obstacle_Detection:"))
            {
                string obs = read.Substring(read.IndexOf(" ")).Trim();
                this.Invoke(new MethodInvoker(delegate {
                    textBox4.Text = obs;
                }));

            }

            return "";
        }
        public string myMethod5(string read)
        {
            if (read.StartsWith("Obstacle_Detection:"))
            {
                string obs = read.Substring(read.IndexOf("Obstacle")).Trim();
                this.Invoke(new MethodInvoker(delegate {
                    textBox5.Text = obs;
                }));

            }

            return "";
        }
        public string myMethod6(string read)
        {
            if (read.StartsWith("Obstacle_Detection:"))
            {
                string obs = read.Substring(read.IndexOf("Obstacle")).Trim();
                this.Invoke(new MethodInvoker(delegate {
                    textBox6.Text = obs;
                }));

            }

            return "";
        }
        public string myMethod7(string read)
        {
            if (read.StartsWith("Obstacle_Detection:"))
            {
                string obs = read.Substring(read.IndexOf("Obstacle")).Trim();
                this.Invoke(new MethodInvoker(delegate {
                    textBox7.Text = obs;
                }));

            }

            return "";
        }
        public string myMethod8(string read)
        {
            if (read.StartsWith("Obstacle_Detection:"))
            {
                string obs = read.Substring(read.IndexOf("Obstacle")).Trim();
                this.Invoke(new MethodInvoker(delegate {
                    textBox8.Text = obs;
                }));

            }

            return "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            s.proccessor(this.myMethod);
            s.open((string)comboBox1.SelectedItem);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            s.proccessor(this.myMethod2);
            s.open((string)comboBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            s.proccessor(this.myMethod3);
            s.open((string)comboBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            s.proccessor(this.myMethod4);
            s.open((string)comboBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            s.proccessor(this.myMethod5);
            s.open((string)comboBox1.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            s.proccessor(this.myMethod6);
            s.open((string)comboBox1.SelectedItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            s.proccessor(this.myMethod7);
            s.open((string)comboBox1.SelectedItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            s.proccessor(this.myMethod8);
            s.open((string)comboBox1.SelectedItem);
        }
    }
}
