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

namespace _13_IHateWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label.BackColor = Color.Red;
            Func<int> func = new Func<int>(Sum);
            var task = Task.Run(func.Invoke);
            task.Wait();
            label.Text = task.Result.ToString();
            if (task.IsCompleted)
            {
                label.BackColor = Color.Green;
            }
        }
        public static int Sum()
        {
            Thread.Sleep(2000);
            return 2 + 2;
        }
        static async Task<string> Callback(string s)
        {
            Thread.Sleep(2000);
            return s + " callback";
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            label.BackColor = Color.Red;
            Func<int> func = new Func<int>(Sum);
            var task = Task.Run(func.Invoke);
            var a = await Callback(task.Result.ToString());
            task.Wait();
            label.Text = a;
            label.BackColor = Color.Green;
        }
    }
}
