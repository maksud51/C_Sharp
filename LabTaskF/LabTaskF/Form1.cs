using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTaskF
{
    public partial class GameUi : Form
    {
        public GameUi()
        {
            InitializeComponent();
        }

        string P1 = "X";
        string P2 = "O";
        int count = 0;
        string tp1 = "Player1";
        string tp2 = "Player2";



/*        public void turnplayer()
        {
            if (count % 2 == 0)
            {
                playerTurn.Text = tp1;
            }

            else
            {
                playerTurn.Text = tp2;
            }
        }*/

        private void Player11_Click(object sender, EventArgs e)
        {


            if (count % 2 == 0)
            {
                Player11.Text = P2;
                playerTurn.Text = tp1;
                count++;
            }

            else
            {
                Player11.Text = P1;
                playerTurn.Text = tp2;
                count++;
            }
         
            


/*            Player11.Text = P1;
            playerTurn.Text = tp2;
            count++;*/
            
        }

        private void player21_Click(object sender, EventArgs e)
        {

            if (count % 2 == 0)
            {
                player21.Text = P2;
                playerTurn.Text = tp1;
                count++;
            }

            else
            {
                player21.Text = P1;
                playerTurn.Text = tp2;
                count++;
            }
            /*            player21.Text = P2;
                        playerTurn.Text = tp1;
                        count++;*/
        }

        private void player12_Click(object sender, EventArgs e)
        {
            /*            player12.Text = P1;
                        playerTurn.Text = tp2;

                        count++; */
            if (count % 2 == 0)
            {
                player12.Text = P2;
                playerTurn.Text = tp1;
                count++;
            }

            else
            {
                player12.Text = P1;
                playerTurn.Text = tp2;
                count++;
            }



        }

        private void player22_Click(object sender, EventArgs e)
        {
            /*            player22.Text = P2;
                        playerTurn.Text = tp1;
                        count++;*/

            if (count % 2 == 0)
            {
                player22.Text = P2;
                playerTurn.Text = tp1;
                count++;
            }

            else
            {
                player22.Text = P1;
                playerTurn.Text = tp2;
                count++;
            }

        }

        private void player13_Click(object sender, EventArgs e)
        {
            /*            player13.Text = P1;
                        playerTurn.Text = tp2;
                        count++; */
            if (count % 2 == 0)
            {
                player13.Text = P2;
                playerTurn.Text = tp1;
                count++;
            }

            else
            {
                player13.Text = P1;
                playerTurn.Text = tp2;
                count++;
            }
        }

        private void player23_Click(object sender, EventArgs e)
        {
            /*            player23.Text = P2;
                        playerTurn.Text = tp1;
                        count++;*/

            if (count % 2 == 0)
            {
                player23.Text = P2;
                playerTurn.Text = tp1;
                count++;
            }

            else
            {
                player23.Text = P1;
                playerTurn.Text = tp2;
                count++;
            }
        }


        private void player14_Click(object sender, EventArgs e)
        {
            /*            player14.Text = P1;
                        playerTurn.Text = tp2;
                        count++;*/

            if (count % 2 == 0)
            {
                player14.Text = P2;
                playerTurn.Text = tp1;
                count++;
            }

            else
            {
                player14.Text = P1;
                playerTurn.Text = tp2;
                count++;
            }
        }

        private void player24_Click(object sender, EventArgs e)
        {
            /*            player24.Text = P2;
                        playerTurn.Text = tp1;
                        count++;*/

            if (count % 2 == 0)
            {
                player24.Text = P2;
                playerTurn.Text = tp1;
                count++;
            }

            else
            {
                player24.Text = P1;
                playerTurn.Text = tp2;
                count++;
            }
        }

        private void player15_Click(object sender, EventArgs e)
        {
            /*            player15.Text = P1;
                        playerTurn.Text = tp2;
                        count++;*/
            if (count % 2 == 0)
            {
                player15.Text = P2;
                playerTurn.Text = tp1;
                count++;
            }

            else
            {
                player15.Text = P1;
                playerTurn.Text = tp2;
                count++;
            }
        }

        public void win()
        {

        }








    }
}
