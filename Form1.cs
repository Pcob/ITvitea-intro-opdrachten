using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITvitea_opdrachten_vlaggen_juiste
{
    public partial class Form1 : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 13;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Einde van Quiz" + Environment.NewLine + 
                    "Je hebt : " + score + "goed" + Environment.NewLine + 
                    "Jouw percentage is " + percentage + "%" + Environment.NewLine +
                    "Klik op OK opnieuw te beginnen"
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
                    pictureBox1.Image = Properties.Resources.Rusland_vlag;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Oostenrijk";
                    button2.Text = "Rusland";
                    button3.Text = "Duitsland";
                    button4.Text = "Italie";

                    correctAnswer = 2;


                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.VlagBurgarije;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Bulgarije";
                    button2.Text = "Italie";
                    button3.Text = "Zwitserland";
                    button4.Text = "Frankrijk";

                    correctAnswer = 1;


                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Cyprus;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Griekenland";
                    button2.Text = "Turkije";
                    button3.Text = "Cyprus";
                    button4.Text = "Macedonie";

                    correctAnswer = 3;


                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Denmark;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Belgie";
                    button2.Text = "Zweden";
                    button3.Text = "Noorwegen";
                    button4.Text = "Denenmarken";

                    correctAnswer = 4;


                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Ivoorkust;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Marokko";
                    button2.Text = "Ivoorkust";
                    button3.Text = "Ghana";
                    button4.Text = "Egypte";

                    correctAnswer = 2;


                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Afrika;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Namibie";
                    button2.Text = "Kenia";
                    button3.Text = "Zuid-Afrika";
                    button4.Text = "Botszwana";

                    correctAnswer = 3;


                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.Canada;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Canada";
                    button2.Text = "Verenigde Staten";
                    button3.Text = "Mexico";
                    button4.Text = "Florida";

                    correctAnswer = 1;


                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.Groenland;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Verenidge Staten";
                    button2.Text = "Alaska";
                    button3.Text = "Groenland";
                    button4.Text = "IJsland";

                    correctAnswer = 3;


                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.Venuzuale;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Argentinie";
                    button2.Text = "Venuzuala";
                    button3.Text = "Brazilie";
                    button4.Text = "Colombia";

                    correctAnswer = 2;


                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.Uruguay;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Chili";
                    button2.Text = "Suriname";
                    button3.Text = "Bolivia";
                    button4.Text = "Uruguay";

                    correctAnswer = 4;


                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.Zuid_Korea;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "China";
                    button2.Text = "Taiwan";
                    button3.Text = "Zuid-Korea";
                    button4.Text = "Japan";

                    correctAnswer = 3;


                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.India;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "India";
                    button2.Text = "Nepal";
                    button3.Text = "Tibet";
                    button4.Text = "Pakistan";

                    correctAnswer = 1;


                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.New_Zeeland;

                    lblQuestion.Text = "Uit welk land komt deze vlag?";

                    button1.Text = "Australie";
                    button2.Text = "Nieuw-Zeeland";
                    button3.Text = "Tahiti";
                    button4.Text = "Indonesie";

                    correctAnswer = 2;


                    break;
            }
        }
    }
}
