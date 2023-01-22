using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 , 10};
        string firstChoice;
        string secondChoice;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox pictureBox1;
        PictureBox pictureBox2;
        DateTime startTime, endTime;
        TimeSpan record = new TimeSpan();
        bool firstGame = true;
        bool gameOver = false;



        public Form1()
        {
            InitializeComponent();
            LoadPictures();
        }
        private void LoadPictures()
        {

            for (int i = 0; i < 20; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 100;
                newPic.Width = 100;
                newPic.BackColor = Color.DarkGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                buttons.Controls.Add(newPic);
            }

            RestartGame();

        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }

            if (firstChoice == null)
            {
                pictureBox1 = sender as PictureBox;
                if(pictureBox1.Tag != null && pictureBox1.Image == null)
                {
                    pictureBox1.Image = Image.FromFile("C:/Users/Omer/Downloads/Pics/" + (string)pictureBox1.Tag+".png");
                    firstChoice = (string)pictureBox1.Tag;
                }
            }
            else if(secondChoice == null)
            {
                pictureBox2 = sender as PictureBox;
                if (pictureBox2.Tag != null && pictureBox2.Image == null)
                {
                    pictureBox2.Image = Image.FromFile("C:/Users/Omer/Downloads/Pics/" + (string)pictureBox2.Tag + ".png");
                    secondChoice = (string)pictureBox2.Tag;
                }
            }
            else
            {
                CheckPictures(pictureBox1, pictureBox2);
            }
        }
        private void CheckPictures(PictureBox A, PictureBox B)
        {
            if(firstChoice == secondChoice)
            {
                A.Tag = null;
                B.Tag = null;
            }

            firstChoice = null;
            secondChoice = null;

            foreach (PictureBox pics in pictures.ToList())
            {
                if(pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            if (pictures.All(o => o.Tag == pictures[0].Tag))
            {
                GameOver();
            }

        }
        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void RestartGame()
        {
            startTime = DateTime.Now;

            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();

            numbers = randomList;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }

            gameOver = false;


        }

        private void GameOver()
        {
            endTime = DateTime.Now;
            if (firstGame == true)
            {
                record = endTime - startTime;
                labelRekord.Text = record.Minutes.ToString() + ":" +
                    record.Seconds.ToString() + ":" +
                    record.Milliseconds.ToString();
                firstGame = false;
                
            }
            else
            {
                if (record > endTime - startTime)
                {
                    record = endTime - startTime;
                    labelRekord.Text = record.Minutes.ToString() + ":" +
                    record.Seconds.ToString() + ":" +
                    record.Milliseconds.ToString();
                    MessageBox.Show("Rekord Yenilendi!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uduzdunuz!", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            gameOver = true;
        }
    }
}
