using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Zaderzhka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            firstValue = 0;
            secondValue = 0;
            thirdValue = 0;

            firstClick = false;
            secondClick = false;
            thirdClick = false;

            firstThread = new Thread(FirstThreadFunction);
            secondThread = new Thread(SecondThreadFunction);
            thirdThread = new Thread(ThirdThreadFunction);

            firstThread.IsBackground = true;
            secondThread.IsBackground = true;
            thirdThread.IsBackground = true;

            firstThread.Start();
            firstThread.Suspend();

            secondThread.Start();
            secondThread.Suspend();

            thirdThread.Start();
            thirdThread.Suspend();

            InitializeComponent();
        }

        private void FirstThreadFunction()
        {
            while (true)
            {
                Thread.Sleep(100);
                firstValue++;

                firstBox.Invoke(new Action<string>((s) => firstBox.Text = s), firstValue.ToString());
            }
        }

        private void SecondThreadFunction()
        {
            while (true)
            {
                Thread.Sleep(200);
                secondValue++;

                secondBox.Invoke(new Action<string>((s) => secondBox.Text = s), secondValue.ToString());
            }
        }

        private void ThirdThreadFunction()
        {
            while (true)
            {
                Thread.Sleep(300);
                thirdValue++;

                thirdBox.Invoke(new Action<string>((s) => thirdBox.Text = s), thirdValue.ToString());
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            firstClick = !firstClick;

            if (firstClick)
                firstThread.Resume();
            else
                firstThread.Suspend();
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            secondClick = !secondClick;

            if (secondClick)
                secondThread.Resume();
            else
                secondThread.Suspend();
        }

        private void thirdButton_Click(object sender, EventArgs e)
        {
            thirdClick = !thirdClick;

            if (thirdClick)
                thirdThread.Resume();
            else
                thirdThread.Suspend();
        }
    }
}
