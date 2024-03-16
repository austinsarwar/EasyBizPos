using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBizPos.Forms
{
    public partial class ToastSuccessForm : Form
    {
        int toastX, toastY;
        public ToastSuccessForm()
        {
            InitializeComponent();
            Position();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if(toastY <= 1500)
            {
                toastTimerUp.Stop();

            }
        }
        int y = 100;
        private void timerDown_Tick(object sender, EventArgs e)
            
        {
            y--;
            if(y < 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY >= 800)
                {
                    toastTimerDown.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            toastX = ScreenWidth - this.Width - 30;
            toastY = ScreenHeight - this.Height + 150;
            this.Location = new Point(toastX, toastY);
        }
    }
}
