/// created by : Ian Elliott
/// date       : November 2019
/// description: Time Machine- Based Choose Your Own Adventure Game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LostV2
{
    public partial class Form1 : Form
    {
        
        int scene = 0;

        // random number generator
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            sceneImage.BackgroundImage = Properties.Resources.Hooded;
            SoundPlayer forestPlayer = new SoundPlayer(Properties.Resources.jungle);
            SoundPlayer sadPlayer = new SoundPlayer(Properties.Resources.Sad);



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// indicates which coloured label is activated by whichever button
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1)
                {
                    int randValue = randGen.Next(1, 101);

                    if (randValue > 90) { scene = 3; }
                    else  { scene = 2; }
                
                }
                else if (scene == 2) { scene = 0; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 0; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 6) { scene = 0; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8) { scene = 0; }
                else if (scene == 9) { scene = 11; }
                else if (scene == 10) { scene = 12; }
                else if (scene == 11) { scene = 0; }
                else if (scene == 12) { scene = 0; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 0; }
                else if (scene == 15) { scene = 16; }
                else if (scene == 16) { scene = 0; }
                else if (scene == 17) { scene = 19; }
                else if (scene == 18) { scene = 20; }
                else if (scene == 19) { scene = 22; }
                else if (scene == 20) { scene = 0; }
                else if (scene == 21) { scene = 0; }
                else if (scene == 22) { scene = 23; }
                else if (scene == 23) { scene = 25; }
                else if (scene == 24) { scene = 25; }
                else if (scene == 25) { scene = 29; }
                else if (scene == 26) 
                {
                    int randValue = randGen.Next(1, 101);

                    if (randValue > 70) { scene = 28; }
                    else { scene = 27; }
                }
                else if (scene == 27) { scene = 25; }
                else if (scene == 28) { scene = 0; }
                else if (scene == 29) { scene = 0; }
                else if (scene == 30) { scene = 0; }
                else if (scene == 32) { scene = 0; }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
               
                if (scene == 0) { scene = 7; }
                else if (scene == 2) { scene = 0; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 4) { scene = 0; }
                else if (scene == 5) { scene = 30; }
                else if (scene == 6) { scene = 0; }
                else if (scene == 7) { scene = 9; }
                else if (scene == 8) { scene = 0; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 10) { scene = 13; }
                else if (scene == 11) { scene = 0; }
                else if (scene == 12) { scene = 0; }
                else if (scene == 13) { scene = 15; }
                else if (scene == 14) { scene = 0; }
                else if (scene == 15) { scene = 17; }
                else if (scene == 16) { scene = 0; }
                else if (scene == 18) { scene = 19; }
                else if (scene == 17) { scene = 18; }
                else if (scene == 19) { scene = 21; }
                else if (scene == 20) { scene = 0; }
                else if (scene == 21) { scene = 0; }
                else if (scene == 22) { scene = 24; }
                else if (scene == 23) { scene = 26; }
                else if (scene == 24) { scene = 25; }
                else if (scene == 25) { scene = 33; }
                else if (scene == 26) { scene = 27; }
                else if (scene == 27) { scene = 29; }
                else if (scene == 28) { scene = 0; }
                else if (scene == 29) { scene = 0; }
                else if (scene == 30) { scene = 0; }
                else if (scene == 33) { scene = 32; }
                
            }

            /// Global variable for sounds used
            /// cases signify scene transitions based on code above
            SoundPlayer cheerPlayer = new SoundPlayer(Properties.Resources.Cheering);
            SoundPlayer sadPlayer = new SoundPlayer(Properties.Resources.Sad);
            switch (scene)
            {
                                    


                case 0:
                  

                    sceneImage.BackgroundImage = Properties.Resources.Hooded;
                    outputLabel.Text = "A random hooded figure gives you what they claim to be a working time machine.";
                    redLabel.Text = "Throw this scrapper into a dumpster?";
                    blueLabel.Text = "Take a chance on this over-sized calculator?";
                    break;
                case 1:
                    sceneImage.BackgroundImage = Properties.Resources.Mugged;
                    outputLabel.Text = "You leave this piece of metal behind, only to get mugged by a huge gang of thugs." +
                        "10% chance that you unleash your inner Bruce Lee, 90% chance they beat you senseless.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 2:
                    sceneImage.BackgroundImage = Properties.Resources.Dumpster;
                    sadPlayer.Play();
                    outputLabel.Text = "You barely make it to your feet by the time the ambulance misses you and you almost make it home. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 3:
                    sceneImage.BackgroundImage = Properties.Resources.Inner_Bruce_Lee;
                    outputLabel.Text = "The Dragon is among them and all of the punks scatter.";
                    redLabel.Text = "Call the cops?";
                    blueLabel.Text = "Look for that hooded figure?";
                    break;
                case 4:
                    sceneImage.BackgroundImage = Properties.Resources.Cuffs;
                    sadPlayer.Play();
                    outputLabel.Text = "The cops have already been notified about those poor innocent people you just assaulted, into the cuffs you go. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 5:
                    sceneImage.BackgroundImage = Properties.Resources.Vanished;
                    outputLabel.Text = "You look around for that hooded figure, but they seem to have vanished.";
                    redLabel.Text = "Get treated at the hospital for your injuries?";
                    blueLabel.Text = "Go home?";
                    break;
                case 6:
                    sceneImage.BackgroundImage = Properties.Resources.Bad_Guys;
                    sadPlayer.Play();
                    outputLabel.Text = "The thugs are also there in the emergency room when you arrive, ensuing a massive hospital fight. Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 7:
                    sceneImage.BackgroundImage = Properties.Resources.Tachyons;
                    outputLabel.Text = "Your possession of a tachyon particle time machine  has inspired you to stop horrific events and meet famous people, do you:";
                    redLabel.Text = "Send a rat back in time?";
                    blueLabel.Text = "Test it on yourself?";
                    break;
                case 8:
                    sceneImage.BackgroundImage = Properties.Resources.Rat;
                    sadPlayer.Play();
                    outputLabel.Text = "The excessive space time energy flow on such a small life form has mutated the rat to an immense size and it devours you whole. Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 9:
                    sceneImage.BackgroundImage = Properties.Resources.Time;
                    outputLabel.Text = "You have successfully travelled back in time 5 minutes.";
                    redLabel.Text = "Prevent the Bubonic Plague?";
                    blueLabel.Text = "Save Abraham Lincoln?";
                    break;
                case 10:
                    sceneImage.BackgroundImage = Properties.Resources.Meeting_Lincoln;
                    cheerPlayer.Play();
                    outputLabel.Text = "You tackle the assassin before they even make it into the theatre and reveal their weapon, the president commends you as a national hero.";
                    redLabel.Text = "Catch Jack The Ripper?";
                    blueLabel.Text = "Invent Coca Cola?";
                    break;
                case 11:
                    sceneImage.BackgroundImage = Properties.Resources.Burn;
                    sadPlayer.Play();
                    outputLabel.Text = "You travel back to the 1300s and warn the people of the coming disease, they deem you a witch due to your intelligence and you get burned. Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 12:
                    sceneImage.BackgroundImage = Properties.Resources.Jack;
                    sadPlayer.Play();
                    outputLabel.Text = "A successful arrival to the peak of his criminal days, but as strategically planned as can possibly be, the hunter becomes the hunted. Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 13:
                    sceneImage.BackgroundImage = Properties.Resources.Coke;
                    outputLabel.Text = "You end up creating an even more popular version of Coke and become an overnight billionaire.";
                    redLabel.Text = "Stop the Cold War?";
                    blueLabel.Text = "Prevent the extinction of the Western Black Rhinoceros?";
                    break;
                case 14:
                    sceneImage.BackgroundImage = Properties.Resources.Cold_War;
                    sadPlayer.Play();
                    outputLabel.Text = "You create peace between the US and Russia, they have moved past nukes and are now going after exposed time travelers. Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 15:
                    sceneImage.BackgroundImage = Properties.Resources.Rhino;
                    outputLabel.Text = "The Black Rhino becomes a symbol of continental unity, inspiring all the governments of the world to help end hunger in Africa.";
                    redLabel.Text = "Shake hands with King Arthur and try to see Excalibur?";
                    blueLabel.Text = "Meet Genghis Khan?";
                    break;
                case 16:
                    sceneImage.BackgroundImage = Properties.Resources.Arthur;
                    sadPlayer.Play();
                    outputLabel.Text = "King Arthur breaks your hand and chokes you with it. Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 17:
                    sceneImage.BackgroundImage = Properties.Resources.Khan_Choking;
                    outputLabel.Text = "You see Genghis Khan just as he is accidentally choking on his dinner.";
                    redLabel.Text = "Save Him?";
                    blueLabel.Text = "Even Dictators Get Karma?";
                    break;
                case 18:
                    sceneImage.BackgroundImage = Properties.Resources.Dying_Khan;
                    outputLabel.Text = "Genghis Khan chokes one last final breath, and his first responding soldiers identify you as his murderer.";
                    redLabel.Text = "Go hang With Cowboys";
                    blueLabel.Text = "Go back and save him?";
                    break;
                case 19:
                    sceneImage.BackgroundImage = Properties.Resources.Khan_Meme;
                    outputLabel.Text = "You save his life and the founder of The Mongrel Empire's new look on the value of life has now inspired him to change his ways.";
                    redLabel.Text = "Go see some dinosaurs?";
                    blueLabel.Text = "Catch and eat a dinosaur?";
                    break;
                case 20:
                    sceneImage.BackgroundImage = Properties.Resources.Cowboy;
                    sadPlayer.Play();
                    outputLabel.Text = "You make it back to the wild west and someone misidentifies you as a known fugitive, you quite literally hang with cowboys. Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 21:
                    sceneImage.BackgroundImage = Properties.Resources.Blast;
                    sadPlayer.Play();
                    outputLabel.Text = "You have just discovered fire millions of years early, small mammals of this time period are now super evolved and take over the world, only to be wiped out by the meteor. Our (super distant) ancestors were too big to survive the extinction," +
                        " we never existed and this never happened, cue the paradox. Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 22:
                    sceneImage.BackgroundImage = Properties.Resources.Safe;
                    cheerPlayer.Play();
                    outputLabel.Text = "You land in the water, climb a tree and see some dinosaurs from a safe distance. " +
                        "This time machine is smart and placed you in a strategic spot so you wouldn't leave any fossilized footprints.";
                    redLabel.Text = "Hang out with Michael Jackson?";
                    blueLabel.Text = "Become famous for inventing the dab?";
                    break;
                case 23:
                    sceneImage.BackgroundImage = Properties.Resources.Jackson;
                    outputLabel.Text = "You land in a gathering of fans in a clothing store, he's there but very busy, people are getting suspicious on how you appeared.";
                    redLabel.Text = "Grab a hoodie for a disguise and leave?";
                    blueLabel.Text = "Reveal yourself to the King Of Pop and have him turn your story into a song?";
                    break;
                case 24:
                    sceneImage.BackgroundImage = Properties.Resources.Vikings;
                    sadPlayer.Play();
                    outputLabel.Text = "For some reason you had the bright idea to teach it to a bunch of vikings, swinging their weapons everywhere, as bad things ensue. Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 25:
                    sceneImage.BackgroundImage = Properties.Resources.Crowded;
                    outputLabel.Text = "You make it out of the crowded  building unnoticed and realize what a mistake this has all been.";
                    redLabel.Text = "Burn it senseless?";
                    blueLabel.Text = "Give the time machine to someone else?";
                    break;
                case 26:
                    sceneImage.BackgroundImage = Properties.Resources.Talking_Jackson;
                    outputLabel.Text = "30% chance that he buys the story 70 % chance that he calls the cops.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 27:
                    sceneImage.BackgroundImage = Properties.Resources.Tackle;
                    outputLabel.Text = "The song does  amazing and you are super famous. But someone tackles you and you escape and make a run for it, finding your way into a store...";
                    redLabel.Text = "Leave the building?";
                    blueLabel.Text = "Burn the time machine?";
                    break;
                case 28:
                    sceneImage.BackgroundImage = Properties.Resources.Cuffs;
                    sadPlayer.Play();
                    outputLabel.Text = "Into the cuffs you go. Play Again?";
                    redLabel.Text = "";
                    blueLabel.Text = "Yes";
                    break;
                case 29:
                    sceneImage.BackgroundImage = Properties.Resources.Existence;
                    sadPlayer.Play();
                    outputLabel.Text = "The time machine is gone, erasing you from existence as a result. Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 30:
                    sceneImage.BackgroundImage = Properties.Resources.Game;
                    cheerPlayer.Play();
                    outputLabel.Text = "Thanks For Playing, Way To Win The Short Route! " +
                        "Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 31:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 32:
                    sceneImage.BackgroundImage = Properties.Resources.Playing;
                    outputLabel.Text = "Thanks For Playing " +
                        "Way To Go!" +
                        " Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    break;
                case 33:
                    sceneImage.BackgroundImage = Properties.Resources.Hooded;
                    cheerPlayer.Play();
                    outputLabel.Text = "You travel back to where this all started and give the machine to your younger self.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
