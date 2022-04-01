using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace ChooseYourOwnAdventure
{
    public partial class Form1 : Form
    {
        int page = 0;
        bool timeline = false;
        bool apple = false;
        bool powerBlock = false;

        SoundPlayer swordPlayer = new SoundPlayer(Properties.Resources.sword);
        SoundPlayer doorPlayer = new SoundPlayer(Properties.Resources.door);
        SoundPlayer enginePlayer = new SoundPlayer(Properties.Resources.engine);
        SoundPlayer popPlayer = new SoundPlayer(Properties.Resources.pop);
        SoundPlayer laserPlayer = new SoundPlayer(Properties.Resources.laser);

        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
            DisplayPage();

            specialbutton.Visible = false;
        }

        private void leftbutton_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                outputlabel.Text = "Inside is a device with a weird-looking clock and a button. You press the button and...";
                int randValue = randGen.Next(1, 4);
                if (randValue == 1)
                {
                    page = 101;
                    outputlabel.Text = "You get transported one second into the past and the two versions of yourself dematerialize into dark matter creating a time paradox that ends all of existence. Fun! Play again?";
                    this.Text = $"{randValue}";
                }
                else if (randValue == 2)
                {
                    page = 2;
                    this.Text = $"{randValue}";

                }
                else if (randValue == 3)
                {
                    page = 7;
                    this.Text = $"{randValue}";

                }
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                int randValue = randGen.Next(1, 3);
                if (randValue == 1)
                {
                    outputlabel.Text = "You grab a dropped sword and gloriously jump into the fray. You charge forward and instantly get stabbed. Play again?";
                    page = 101;
                    this.Text = $"{randValue}";
                }
                else if (randValue == 2)
                {
                    outputlabel.Text = "You grab a dropped sword and gloriously jump into the fray. You charge forward and instantly stab an invader. You clash swords with the next, felling him. Rallying behind you, the defending army is able to vanquish the invaders and the country is saved! But your time machine is in shambles. So you're screwed. Play again?";
                    page = 101;
                    this.Text = $"{randValue}";

                }
            }
            else if (page == 4)
            {
                outputlabel.Text = "You persevere and reach the top to place down the time machine. But you slip again down to the roof! Suddenly the top spire is struck with lightning, and the gully charged machine falls down next to you. You press the button!";
                if (timeline == false)
                {
                    timeline = true;
                    page = 201;
                }
                else if (timeline == true)
                {
                    page = 203;
                }
            }
            else if (page == 5)
            {
                outputlabel.Text = "She shouts \"That doesn't exist! You're an invader!\" and ends you with a pitchfork. Play again?";
                page = 101;
            }
            else if (page == 6)
            {
                outputlabel.Text = "You nimbly reach the roof and hold up the machine to charge it, satisfied. It gets struck by lightning. So do you. Play again?";
                page = 101;
            }
            else if (page == 7)
            {
                if (apple == true)
                {
                    specialbutton.Visible = true;
                    specialbutton.Text = "Give him the apple.";
                }
                page = 8;
            }
            else if (page == 8)
            {
                outputlabel.Text = "The man looks away, slams the brakes, and you are in the car no longer. Play again?";
                page = 101;
            }
            else if (page == 9)
            {
                outputlabel.Text = "He takes you to a lab where they'll examine your time traveling experiences. As you get there they confiscate your machine. \"Sorry,\" he says \"Time travelers are rare nowadays.You're staying with us.\" Life in the future is cool until their experiment fails and so do you. Play again?";
                page = 101;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                outputlabel.Text = "The scientists watch you emotionless as you hop into their device. What were you thinking? You're electrocuted! Play again?";
                page = 101;
            }
            else if (page == 101)
            {
                page = 1;
            }
            else if (page == 102)
            {
                page = 1;
            }
            else if (page == 201)
            {
                page = 1; int randValue = randGen.Next(1, 6);
                if (randValue == 1)
                {
                    page = 102;
                }
                else
                {
                    page = 7;
                }
            }
            else if (page == 202)
            {
                page = page = 1; int randValue = randGen.Next(1, 6);
                if (randValue == 1)
                {
                    page = 102;
                }
                else
                {
                    page = 2;
                };
            }
            else if (page == 203)
            {
                page = 102;
            }
            DisplayPage();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            page = 1;
            
            startbutton.Visible = false;
            leftbutton.Visible = true;
            rightbutton.Visible = true;
            titlelabel.Visible = false;

            DisplayPage();
        }
        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputlabel.Text = "A package arrives on your doorstep. What do you do?";
                    leftbutton.Text = "Pick it up!";
                    rightbutton.Text = "Leave it.";
                    picturebox.Image = Properties.Resources.doorstep;
                    doorPlayer.Play();
                    break;
                case 2:
                    outputlabel.Text = "You got transported to the past! Your town is replaced by a medieval village with a castle in the distance in the middle of a thunderstorm! You try to travel back to the present but the machine is out of power.";
                    leftbutton.Text = "Go to the castle!";
                    rightbutton.Text = "Shelter in a farmhouse.";
                    picturebox.Image = Properties.Resources.townii;
                    popPlayer.Play();
                    break;
                case 3:
                    outputlabel.Text = "A battle is raging! An army of defending troops against a skilled group of invaders. Sword clashes ring through the air. What do you do?";
                    leftbutton.Text = "Join the battle!";
                    rightbutton.Text = "Climb the castle.";
                    picturebox.Image = Properties.Resources.castle;
                    swordPlayer.Play();
                    break;
                case 4:
                    outputlabel.Text = "You duck under many arrows and hop over fallen swords before reaching the castle. You find some cracked bricks to climb and scale the massive castle. You almost reach the top spire before slipping and collapsing on the roof. Now what?"; ;
                    leftbutton.Text = "Keep climbing to the top!";
                    rightbutton.Text = "Break through the window to the throne room!";
                    swordPlayer.Play();
                    break;
                case 5:
                    outputlabel.Text = "You knock on the door and a woman walks out. When you ask for shelter she quizzes you \"What crop am I farming?\"";
                    leftbutton.Text = "Oranges?";
                    rightbutton.Text = "Apples?";
                    picturebox.Image = Properties.Resources.farmhouse;
                    doorPlayer.Play();
                    break;
                case 6:
                    outputlabel.Text = "She rushes you inside. \"Those invaders always strike during a storm!\" She gives you an apple. You need to recharge the time machine, maybe with lightning? What do you do?";
                    leftbutton.Text = "Climb the chimney.";
                    rightbutton.Text = "Throw it onto an apple tree.";
                    doorPlayer.Play();
                    break;
                case 7:
                    outputlabel.Text = "You got transported to the future! A technological city with floating cars and a skyscraper through the clouds! But your machine is out of power so you're stranded here.";
                    leftbutton.Text = "Hop in a flying car.";
                    rightbutton.Text = "Go to a skyscraper!";
                    picturebox.Image = Properties.Resources.city;
                    popPlayer.Play();
                    break;
                case 8:
                    outputlabel.Text = "The car is very shiny with glass screens everywhere. The guy driving looks at you very confused. \"Uhh, what are you doing?\"";
                    leftbutton.Text = "Trying a flying car, duh!";
                    rightbutton.Text = "Trying to charge my time machine!";
                    picturebox.Image = Properties.Resources.car;
                    enginePlayer.Play();
                    break;
                case 9:
                    outputlabel.Text = "The man relaxes. \"Oh, of course!You must be new here.I can charge that for you,\" he points to a futuristic power block, \"but I'd like to asks you some questions first.\"";
                    leftbutton.Text = "Go along with it.";
                    rightbutton.Text = "Grab the power block for yourself.";
                    enginePlayer.Play();
                    break;
                case 10:
                    outputlabel.Text = "The massive sign says \"Goople Canada\". You walk in and see an elevator and a front desk. What do you do?";
                    leftbutton.Text = "Get in the elevator.";
                    rightbutton.Text = "Ask the front desk.";
                    picturebox.Image = Properties.Resources.skyscraper;
                    laserPlayer.Play();
                    break;
                case 11:
                    outputlabel.Text = "The secretary stands up and shouts at you but the elevator doors close, but there are no elevator buttons. You wait in the rising elevator for three minutes before the door opens on the top floor. There is electricity sparking everywhere in this development sector. Now what?";
                    leftbutton.Text = "Jump into one of the experiments";
                    rightbutton.Text = "Run through and jump out the window";
                    doorPlayer.Play();
                    break;
                case 101:
                    leftbutton.Text = "Yes";
                    rightbutton.Text = "No";
                    popPlayer.Play();
                    break;
                case 102:
                    outputlabel.Text = "You made your way home! Congrats!... Play again?";
                    leftbutton.Text = "Yes";
                    rightbutton.Text = "No";
                    popPlayer.Play();
                    break;
                case 201:
                    leftbutton.Text = "Continue";
                    rightbutton.Text = "";
                    popPlayer.Play();
                    break;
                case 202:
                    leftbutton.Text = "Continue";
                    rightbutton.Text = "";
                    popPlayer.Play();
                    break;
                case 203:
                    leftbutton.Text = "Continue";
                    rightbutton.Text = "";
                    Refresh();
                    popPlayer.Play();
                    break;
            }
        }

        private void rightbutton_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                outputlabel.Text = "Well, nothing happened. That's boring. You should play again!";
                page = 101;
            }
            else if (page == 2)
            {
                if (powerBlock == true)
                {
                    specialbutton.Visible = true;
                    specialbutton.Text = "Give her the power block.";
                }
                page = 5;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                outputlabel.Text = "You burst through the glass as shards cascade around you. The king and his company are hiding under a large table. \"King, who the blunderbuss is this idiot?\" \"I dunno.Stab 'im.\" They do! Play again?";
                page = 101;
            }
            else if (page == 5)
            {

                specialbutton.Visible = false;
                apple = true;
                page = 6;
            }
            else if (page == 6)
            {
                outputlabel.Text = "The machine rests on the tallest apple tree. It's soon struck by lightning and charges! You grab it by the ashes of the former tree and press the button.";
                if (timeline == false)
                {
                    timeline = true;
                    page = 201;
                }
                else if (timeline == true)
                {
                    page = 203;
                }
            }
            else if (page == 7)
            {
                page = 10;
            }
            else if (page == 8)
            {

                specialbutton.Visible = false;
                page = 9;
            }
            else if (page == 9)
            {
                powerBlock = true;
                outputlabel.Text = "You scramble to find a cord on the time machine and quickly plug it into the outlet. The guy turns around. \"So, yes or no - STOP! Energy costs are through the roof!!\" The machine lights up and you press the button.";
                if (timeline == false)
                {
                    timeline = true;
                    page = 202;
                }
                else if (timeline == true)
                {
                    page = 203;
                }
            }
            else if (page == 10)
            {
                outputlabel.Text = "The secretary is surprised you're a time traveler. They look at your time machine. \"Those are illegal! SECURITY!!\" Play again?";
                page = 101;
            }
            else if (page == 11)
            {
                outputlabel.Text = "You run through all the scientists and experiments, the machine is charged just by the sparking air and you jump out the window. Falling, you smack the button!";
                if (timeline == false)
                {
                    timeline = true;
                    page = 202;
                }
                else if (timeline == true)
                {
                    page = 203;
                }
            }
            else if (page == 101)
            {
                outputlabel.Text = "Have a nice day! (AND PLEASE PLAY AGAIN)";
                Refresh();
                Thread.Sleep(3000);
                this.Close();
            }
            else if (page == 102)
            {
                outputlabel.Text = "Have a nice day! (AND PLEASE PLAY AGAIN)";
                Refresh();
                Thread.Sleep(3000);
                this.Close();
            }
                DisplayPage();

        }

        private void specialbutton_Click(object sender, EventArgs e)
        {
            if (page == 5)
            {
                outputlabel.Text = "\"So you're from the future?\" She asks as she takes it inside and fiddles with it. She uses the fireplace heat to charge it up and you press the button!";
                page = 203;

                specialbutton.Visible = false;
            }
            if (page == 8)
            {
                outputlabel.Text = "\"Yo we haven't been able to find apples yet! They've been extinct for so long! Charge that machine on up!\" You press the button!";
                page = 203;

                specialbutton.Visible = false;
            }
            DisplayPage();
        }
    }
}
