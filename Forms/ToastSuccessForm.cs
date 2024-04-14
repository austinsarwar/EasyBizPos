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
        bool isGoingUp = true; // State to track whether the toast is going up or down

        public ToastSuccessForm()
        {
            InitializeComponent();
            Position();
            toastTimerUp.Start(); // Start the 'going up' timer when the form loads
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGoingUp)
            {
                // Going up
                toastY -= 4; // Modify this value to adjust the speed
                this.Location = new Point(toastX, toastY);

                // When reached the desired height, start going down
                if (toastY <= Screen.PrimaryScreen.WorkingArea.Height - 200) // Adjust target Y position as desired
                {
                    isGoingUp = false; // Change state to going down
                    toastTimerUp.Stop();
                    toastTimerDown.Start();
                }
            }
        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            // Going down
            toastY += 4; // Modify this value to adjust the speed
            this.Location = new Point(toastX, toastY);
            if (toastY >= Screen.PrimaryScreen.WorkingArea.Height - this.Height)
            {
                toastTimerDown.Stop();
                this.Close(); // Close the form when it reaches the bottom
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            toastX = ScreenWidth - this.Width - 30;
            toastY = ScreenHeight - this.Height + 150; // Starting Y position
            this.Location = new Point(toastX, toastY);
        }
    }
 }
