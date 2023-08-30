using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SlotMachine
{
    public partial class Default : System.Web.UI.Page
    {

        string[] imageUrls = { "/cherry.jpg", "/horseshoe.jpg", "/shamrock.jpg" };

        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "./Images/cherry.jpg";
            Image2.ImageUrl = "./Images/cherry.jpg";
            Image3.ImageUrl = "./Images/cherry.jpg";
        }

        protected void BtnLever_Click(object sender, EventArgs e)
        {
            int bet; 
            bool success = int.TryParse(TxtBet.Text.Trim(), out bet);
            if (!success)
            {
                LblResult.Text = "Please enter an integer";
                LblMoney.Text = "";
            }
            else
            {
                RunSlots(bet);
            }
        }

        private void RunSlots(int bet)
        {
            // generate 3 random numbers
            Random rand = new Random();
            int[] imgs = new int[3];

            for (int i = 0; i < 3; i++)
            {
                imgs[i] = rand.Next(0, 3);
            }

            // assign images from the rand numbers
            AssignImages(imgs);
            int winnings = bet * GetWinnings(imgs);

            LblMoney.Text = $"You bet ${bet} and won ${winnings}";
        }

        private int GetWinnings(int[] nums)
        {
            // set font color to black
            LblResult.ForeColor = Color.Black;
            // check for number of cherries or 3 horseshoes
            int cherries = 0;
            int horseshoes = 0;
            int retval = 0;
            foreach(var x in nums)
            {
                if (x == 0) cherries++;
                if (x == 1) horseshoes++;
            }

            if (horseshoes == 3)
            {
                LblResult.Text = "!!!-----Jackpot-----!!!";
                LblResult.ForeColor = Color.Red;
                return 100;
            }
            else if (cherries == 1) retval = 2;
            else if (cherries == 2) retval = 3;
            else if (cherries == 3) retval = 4;

            LblResult.Text = $"{cherries} cherries";
            return retval;
        }

        private void AssignImages(int[] nums)
        {
            Image1.ImageUrl = $"./Images{imageUrls[nums[0]]}";
            Image2.ImageUrl = $"./Images{imageUrls[nums[1]]}";
            Image3.ImageUrl = $"./Images{imageUrls[nums[2]]}";

        }
    }
}