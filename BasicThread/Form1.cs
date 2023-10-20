using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }
        private Thread ThreadA, ThreadB;

        private void button1_Click(object sender, EventArgs e)
        {
    
            ThreadStart start = new ThreadStart(MyThreadClass.Thread1);
            Console.WriteLine(label1.Text.ToString());

            ThreadA = new Thread(start);
            ThreadA.Name = "Thread A Process = ";
            ThreadA.Start();

            ThreadB = new Thread(start);
            ThreadB.Name = "Thread B Process = ";
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {
            
        }
    }
}
