using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDigitsInMatrix
{
    public partial class frmCountDigitsInMatrix : Form
    {
        //General 
        Random rand = new Random();
        Random RandIndex = new Random();
        int[] NumArr = new int[25];

        struct stGameStatus
        {
            public int Digit;
            public int TimesOfRepeatedDigit;
        }
        stGameStatus GameStatus;




        

        private void frmCountDigitsInMatrix_Load(object sender, EventArgs e)
        {
            GenerateRandomNumbers();
            txtAnswer.Select();
        }

        void FillButtonWithRandomValue(Button btn)
        {
            int RandomNum = rand.Next(0, 90);
            btn.Text = RandomNum.ToString();
            int index = Convert.ToInt32(btn.Name.Replace("button", ""));
            NumArr[index - 1] = RandomNum; 
        }
        int DigitRepeatedTimes()
        {
            int RepeatedTimes = 0;
            foreach (int Number in NumArr)
            {
                if (Number == GameStatus.Digit)
                    RepeatedTimes++;
            }
            return RepeatedTimes;
        }
        void DigitToFind()
        {
            GameStatus.Digit = NumArr[RandIndex.Next(0, 25)];
            lblDigit.Text = GameStatus.Digit.ToString();
            GameStatus.TimesOfRepeatedDigit = DigitRepeatedTimes();
        }

        public frmCountDigitsInMatrix()
        {
            InitializeComponent();
        }
        void GenerateRandomNumbers()
        {
            FillButtonWithRandomValue(button1);
            FillButtonWithRandomValue(button2);
            FillButtonWithRandomValue(button3);
            FillButtonWithRandomValue(button4);
            FillButtonWithRandomValue(button5);
            FillButtonWithRandomValue(button6);
            FillButtonWithRandomValue(button7);
            FillButtonWithRandomValue(button8);
            FillButtonWithRandomValue(button9);
            FillButtonWithRandomValue(button10);
            FillButtonWithRandomValue(button11);
            FillButtonWithRandomValue(button12);
            FillButtonWithRandomValue(button13);
            FillButtonWithRandomValue(button14);
            FillButtonWithRandomValue(button15);
            FillButtonWithRandomValue(button16);
            FillButtonWithRandomValue(button17);
            FillButtonWithRandomValue(button18);
            FillButtonWithRandomValue(button19);
            FillButtonWithRandomValue(button20);
            FillButtonWithRandomValue(button21);
            FillButtonWithRandomValue(button22);
            FillButtonWithRandomValue(button23);
            FillButtonWithRandomValue(button24);
            FillButtonWithRandomValue(button25);

            DigitToFind();
        }
        
        
        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            GenerateRandomNumbers();
        }

        void ResetItems()
        {
            GenerateRandomNumbers();
            txtAnswer.Text = "";
            txtAnswer.Select();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(txtAnswer.Text == GameStatus.TimesOfRepeatedDigit.ToString())
            {
                MessageBox.Show("Right Answer!", "Correct", MessageBoxButtons.OK);
                ResetItems();
            }
            else
            {
                if(MessageBox.Show("Wrong Answer ):\n\nDo you want to Restart the game and Show the Right Answer?", "Wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show($"Write Answer is {GameStatus.TimesOfRepeatedDigit}", "Right Answer is . . .", MessageBoxButtons.OK);
                    ResetItems();
                }
                else
                {
                    MessageBox.Show("Don't Gave Up !", "Try Again. . .", MessageBoxButtons.OK);
                    txtAnswer.Text = "";
                    txtAnswer.Select();

                }
            }
        }
    }
}
