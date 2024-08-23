using System;
using System.Windows.Forms;

namespace FindNumber
{
    public partial class Form1 : Form
    {
        private int findNumber = 0;
        private int chance = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            findNumber = rand.Next(1, 21);
            chance = 5;
            display.Text = "맞힐 숫자를 입력하세요.";
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            int inputNumber = Int32.Parse(textBox.Text);
            chance--;

            if (chance <= 0)
            {
                display.Text = "기회를 모두 소진하셨습니다.";
            }
            else if (inputNumber == findNumber)
            {
                display.Text = "승리했습니다.";
            }
            else if(inputNumber > findNumber)
            {
                display.Text = "Down! 기회는 " + chance + "회 남았습니다.";
            }
            else if(inputNumber < findNumber)
            {
                display.Text = "Up! 기회는 " + chance + "회 남았습니다.";
            }
        }
    }
}