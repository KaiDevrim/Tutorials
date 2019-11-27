using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class game : Form
    {
        double currentCookies;
        double upgradeOneCookies = 0;
        double upgradeOneCost = 10;
        //double upgradeOne = 10;
        public game()
        {
            InitializeComponent();
        }

        private void Clicker_Click(object sender, EventArgs e)
        {
            currentCookies = 1 + currentCookies + upgradeOneCookies;
            
            cookies.Text = $"You have {currentCookies} cookies!";


        }

        private void Cookies_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpgradeOne_Click(object sender, EventArgs e)
        {
            
            
            if (currentCookies >= upgradeOneCost)
            {
                upgradeOneCookies++;
                upgradeOneCost++;
                currentCookies = currentCookies - 10;
                cookies.Text = $"You have {currentCookies} cookies!";

            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            currentCookies = 1 + currentCookies + upgradeOneCookies;
            cookies.Text = $"You have {currentCookies} cookies!";
        }
        

        private void Cookei_Click(object sender, EventArgs e)
        {

        }

        private void UpgradeOneCost_Click(object sender, EventArgs e)
        {

        }
    }
}
