﻿using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Enter your name:  Yossi Rotenstreich

namespace ConjectureGUIApp
{
    public partial class Form1 : Form
    {
        private bool cancelRequested;

        public Form1()
        {
            InitializeComponent();
        }

        private async void CalculateButton_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Clear();
            cancelRequested = false;
            int limit = int.Parse(LimitTextBox.Text);
            
            for (int i = 4; i <= limit; i++)
            {
                if (cancelRequested)
                {
                    break;
                }
                int temp = i;
                string result = await Task.Run(() => GetPair(temp));
                ResultsTextbox.AppendText(result);
            }
            ResultsTextbox.AppendText(cancelRequested ? "Cancelled" : "Done");
        }

        
        private String GetPair(int currNumber)
        {
            String result = "";
            for (int i = 2; i < currNumber; i++)
            {
                if (!IsPrime(i))
                    continue;
                for (int j = 2; j < currNumber; j++)
                {
                    if (!IsPrime(j))
                        continue;
                    if (i + j == currNumber)
                        result = $"{currNumber}: {i} + {j}\r\n";
                }
            }

            return result;
        }

        private static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            cancelRequested = true;
        }





    }
}
