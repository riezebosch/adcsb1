using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci.Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var t = Task.Run(() => { Thread.Sleep(5000); return 3; });
            Console.WriteLine(t.Result);

            int n = int.Parse(textBox1.Text);

            try
            {
                int result = await Bereken(n);
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //var t = new Thread(Execute);
            //t.Start();
            
        }

        private Task<int> Bereken(int n)
        {
            
            return Task.Run(() => FibonacciRecursief.Bereken(n));
        }


        //private void Execute(object o)
        //{
        //    int n = int.Parse(textBox1.Text);
        //    int result = FibonacciRecursief.Bereken(n);
            
        //    this.Invoke(new Action(() => label1.Text = result.ToString()));
        //}

    }
}
