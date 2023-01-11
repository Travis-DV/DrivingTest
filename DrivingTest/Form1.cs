using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingTest
{
    public partial class Form1 : Form
    {
        private string[] questions = {
            "At a railroad crossing, you must stop ____ before the railroad tracks.",
            "If you are about to pass a bicycle to your right and an oncoming vehicle is approaching you on your left, what should you do?",
            "When are you allowed to pass on the right",
            "If your vehicle starts to hydroplane, your should",
            "If you are under 21 years of age and are cought driving with a blood alcohol content (BAC) of ____, your drivers license may be suspended.",
            "When turning corners, turn the steering wheel using",
            "Under normal roadway conditions, you may not drive slower than ____ on interstate highways.",
            "According to Missouri law, ______ must wear seat belts if the driver holds an intermediate drivers license.",
            "To obtain a driver license, you must pass",
            "If there are no traffic signals, you must slow down or stop for pedestrians in",
            "When passing another vehicle, get through the other driver's blind spot as quickly as you can",
            "When turning left from a two-way street onto a one-way street, you should",
            "When approaching a roundabout, you must",
            "The first step in Missouri's Graduated Drivers License Program for young drivers is",
            "When entering a highway, use the entrance ramp and ____ to increase your speed to match the speed of highway traffic.",
            "If your are approaching a school bus that has stopped to take on or discharge young passengers. You do NOT have to stop for the school bus if",
            "If there are two solid yellow lines next to your lane, you must",
            "You have parked next to a curb, facing downhill. Which way should you point your front wheels?",
            "In Missouri, when following a vehicle at night, you must use your low beams",
            "To pass a motorcycle, you should"
        };
        private string[,] answers = {
            { "between 10 and 45 feet", "between 15 and 50 feet", "between 15 and 20 feet", "between 5 and 50 feet" },
            { "Drive bewtween the vehicle and the bicycle", "Sound your horn to warn the bicyclist of the oncoming vehicle", "Increase your speed and pass the bicycle first", "Slow down and let tjee vehicle pass first" },
            { "If the vehicle is making or about to make a left turn", "If the vehicle is making or about to make a right turn", "On a two-lane road", "In none of the above situations" },
            { "slow down gradually", "depress the accelerator", "brake hard", "do all of the above" },
            { "0.06% or more", "0.08% or more", "0.02% or more", "0.04% or more" },
            { "the hand-over-hand technique", "one hand", "the single-hand technique", "the hand off hand technique" },
            { "60 mph", "40 mph", "50 mph", "25 mph" },
            { "the driver and all passengers", "the driver and backseat passengers", "the driver and front-seat passangers", "only the driver" },
            { "a vision test, a written test, a vehicle test, and a fitness test.", "a vision test, a road sign test, a vehicle test, and a fitness test.", "a vision test, a written test, a road sign test, and a driving test.", "a vision test, a written test, a driving test, and a vehicle test." },
            { "an intersection", "an unmarked crosswalk", "a marked crosswalk", "all of the above" },
            { "by shifting gears.", "without exceeding the speed limit.", "by reducing your speed.", "by increasing your speed" },
            { "swing wide to the right before turning", "begin the turn with your right wheel as close as possible to the yellow dividing line.", "begin the turn with your left wheel as close as possible to the yellow dividing line.", "do any of the above." },
            { "enter from the left.", "activate your left turn signal to exit.", "yield to traffic in the roundabout and pedestrians in crosswalks.", "move in a clockwise direction." },
            { "to obtain an instruction permit.", "to obtain a full driver license.", "to obtain automobile insurance.", "to obtain an intermediate license." },
            { "uncontrolled access path", "sholder lane", "deceleration lane", "acceleration lane" },
            { "you are traveling on a one-way street.", "you are traveling on a roadway in the same direction as the bus.", "you are traveling on a divided highway in the opposite direction of the bus.", "you are traveling on an undivided roadway in the opposite direction" },
            { "cross the lines only during permotted times.", "cross the lines only to pass.", "never cross the lines to pass or change lanes.", "treat them asa a single broken yellow line." },
            { "Away from the curb", "Toward the curb", "Straight", "In any direction" },
            { "witin 400 feet of the vehicle ahead.", "witin 350 feet of the vehicle ahead.", "witin 450 feet of the vehicle ahead.", "witin 300 feet of the vehicle ahead." },
            { "pass in an adjacent lane.", "not pass in an adjacent lane.", "use the rightmost lane.", "use the same lane as the motorcycle." }
        };
        //correct, incorrect
        int totalcorrect = 0;
        int[] correctanswerindex = { 1, 3, 0, 0, 2, 0, 1, 0, 2, 3, 1, 2, 3, 0, 3, 2, 2, 1, 3, 0 };
        int questionindex = 0;

        private void centercontrol(Control centercontrol, int widthbuffer = 0, int heightbuffer = 0)
        {
            //width height
            int[] buffer = { widthbuffer, heightbuffer };
            int width = (this.Size.Width / 2) - (centercontrol.Width / 2) + buffer[0];
            int height = (this.Size.Height / 2) - (centercontrol.Height / 2) + buffer[1];
            centercontrol.Location = new Point(width, height);
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centercontrol(questionLB, heightbuffer: -105);
            centercontrol(qustionanswers, heightbuffer: -65);
            centercontrol(submitBUT, heightbuffer: -25);
            centercontrol(answeroutputLB, heightbuffer: 0);
        }

        private void SubmitBUT_Click(object sender, EventArgs e)
        {
            if (submitBUT.Text == "Submit")
            {
                if (qustionanswers.SelectedIndex != -1)
                {
                    if (qustionanswers.SelectedIndex == correctanswerindex[questionindex])
                    {
                        totalcorrect++;
                        answeroutputLB.Text = "CORRECT";
                    }
                    else if (qustionanswers.SelectedIndex != correctanswerindex[questionindex])
                    {
                        string[] answerletters = { "A", "B", "C", "D" };
                        answeroutputLB.Text = $"The correct answer was: {answerletters[correctanswerindex[questionindex]]}";
                    }
                    submitBUT.Text = "Next";
                }
                else if (qustionanswers.SelectedIndex == -1)
                {
                    answeroutputLB.Text = "please select an answer";
                }
            }
            else if (submitBUT.Text == "Next")
            {
                questionindex += 1;
                if (questionindex == 20)
                {
                    if (totalcorrect > 14) MessageBox.Show($"That was the end of the test you finished with a passing {(totalcorrect / 20) * 100}%");
                    if (totalcorrect <= 14) MessageBox.Show($"That was the end of the test you finished with a failing {(totalcorrect / 20) * 100}%");
                }
                else if (questionindex < 20)
                {
                    qustionanswers.ClearSelected();
                    questionLB.Text = questions[questionindex];
                    for (int i = 0; i < 4; i++)
                    {
                        qustionanswers.Items[i] = answers[questionindex, i];
                    }
                    submitBUT.Text = "Submit";
                    answeroutputLB.Text = "The correct answer was: ";
                }
            }
            centercontrol(questionLB, heightbuffer: -105);
            centercontrol(qustionanswers, heightbuffer: -65);
            centercontrol(submitBUT, heightbuffer: -25);
            centercontrol(answeroutputLB, heightbuffer: 0);
            //answeroutputLB.Text = questionindex.ToString();
        }
    }
}
