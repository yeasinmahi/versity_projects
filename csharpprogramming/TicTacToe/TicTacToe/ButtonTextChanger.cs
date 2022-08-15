using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    class ButtonTextChanger
    {
        Button button;
        Button[] btnArr;
        Label Lb;
        public ButtonTextChanger(Button[] bArr)
        {
            this.btnArr = bArr;
        }
        public bool degn(Button btn, bool pl, Label lb)
        {
            this.button = btn;
            this.Lb = lb;
            
            if (pl == true)
            {
                btn.Text = "O";
                lb.Text = "Player 1";
                return false;
            }
            else
            {
                btn.Text = "X";
                lb.Text = "Player 2";
                return true;
            }
        }
        public void win()
        {
            if ((btnArr[0].Text == "X" && btnArr[1].Text == "X" && btnArr[2].Text == "X") || (btnArr[3].Text == "X" && btnArr[4].Text == "X" && btnArr[5].Text == "X") || (btnArr[6].Text == "X" && btnArr[7].Text == "X" && btnArr[8].Text == "X") || (btnArr[0].Text == "X" && btnArr[3].Text == "X" && btnArr[6].Text == "X") || (btnArr[1].Text == "X" && btnArr[4].Text == "X" && btnArr[7].Text == "X") || (btnArr[2].Text == "X" && btnArr[5].Text == "X" && btnArr[8].Text == "X") || (btnArr[0].Text == "X" && btnArr[4].Text == "X" && btnArr[8].Text == "X") || (btnArr[2].Text == "X" && btnArr[4].Text == "X" && btnArr[6].Text == "X"))
            {
                MessageBox.Show(" Player 1 is Winer"); 
            }
            else if ((btnArr[0].Text == "O" && btnArr[1].Text == "O" && btnArr[2].Text == "O") || (btnArr[3].Text == "O" && btnArr[4].Text == "O" && btnArr[5].Text == "O") || (btnArr[6].Text == "O" && btnArr[7].Text == "O" && btnArr[8].Text == "O") || (btnArr[0].Text == "O" && btnArr[3].Text == "O" && btnArr[6].Text == "O") || (btnArr[1].Text == "O" && btnArr[4].Text == "O" && btnArr[7].Text == "O") || (btnArr[2].Text == "O" && btnArr[5].Text == "O" && btnArr[8].Text == "O") || (btnArr[0].Text == "O" && btnArr[4].Text == "O" && btnArr[8].Text == "O") || (btnArr[2].Text == "O" && btnArr[4].Text == "O" && btnArr[6].Text == "O"))
            {
                MessageBox.Show(" Player 2 is Winer"); 
            }
            
               // MessageBox.Show("Match Draw");
            
        }
    }
}
