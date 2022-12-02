using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game
{
    public partial class Form1 : Form
    {
        //quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 10;

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            //takes input from sender and access tag, convert to string 
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {

                score++;
            }

            if(questionNumber == totalQuestions)
            {
                //workout the percentage

                percentage = (int)Math.Round((double)(score*100)/ totalQuestions);

                MessageBox.Show(
                    "Quiz Ended! \n" + 
                    "You have answered " + score + " questions correctly! \n" + 
                    "Your total percentage is " + percentage +"%" +
                    "\n Click OK to play again "
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);



            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {

            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.map;
                    lblQuestion.Text = "Which is the first state in United States?";

                    button1.Text = "Texas";
                    button2.Text = "Delaware";
                    button3.Text = "Minnesota";
                    button4.Text = "Utah";

                    correctAnswer = 2;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.mountain;
                    lblQuestion.Text = "Which country has the tallest mountain?";

                    button1.Text = "Switzerland";
                    button2.Text = "USA";
                    button3.Text = "Nepal";
                    button4.Text = "Srilanka";

                    correctAnswer = 3;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.mountain;
                    lblQuestion.Text = "What is the smallest country in the world?";

                    button1.Text = "Liechtenstein";
                    button2.Text = "Tuvalu";
                    button3.Text = "Bhutan";
                    button4.Text = "Vatican City";

                    correctAnswer = 4;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.unicorn;
                    lblQuestion.Text = "Which country has unicorn as it's national animal?";

                    button1.Text = "Maldives";
                    button2.Text = "Netherland";
                    button3.Text = "Scotland";
                    button4.Text = " Iceland";

                    correctAnswer = 3;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.gin;
                    lblQuestion.Text = "Which country invented gin?";

                    button1.Text = "Russia";
                    button2.Text = "Germany";
                    button3.Text = "Holland";
                    button4.Text = " Scotland";

                    correctAnswer = 3;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.whiskey;
                    lblQuestion.Text = "Which country invented whiskey?";

                    button1.Text = "Finland";
                    button2.Text = "Ireland";
                    button3.Text = "Scotland";
                    button4.Text = " Japan";

                    correctAnswer = 3;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    lblQuestion.Text = "The computer mouse speed is measured in what?";

                    button1.Text = "Siriometer";
                    button2.Text = "Foe";
                    button3.Text = "Ticks";
                    button4.Text = " Mickeys";

                    correctAnswer = 4;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources._8;
                    lblQuestion.Text = "Whats on the top floor of US Supreme court building";

                    button1.Text = "Basketball court";
                    button2.Text = "Tennis court";
                    button3.Text = "The Yellow Oval Room";
                    button4.Text = " Cemetery";

                    correctAnswer = 1;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                    lblQuestion.Text = "Which company has lowest acceptance rate than harvard";

                    button1.Text = "Sears";
                    button2.Text = " Mc Donalds";
                    button3.Text = "Seven eleven";
                    button4.Text = " Walmart";

                    correctAnswer = 4;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    lblQuestion.Text = "What shoes were originally created for men but worn by women";

                    button1.Text = "Tennis Shoes";
                    button2.Text = "High heels";
                    button3.Text = "Sandals";
                    button4.Text = "boots ";

                    correctAnswer = 2;
                    break;
            }



        }
    }
}
