using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordBlaster.AbstractFactory;
using WordBlaster.Libraries;
using WordBlaster.Shapes;

namespace WordBlaster
{
    public partial class WordBlasterForm : Form
    {
        //Will be the same for each lane
        FactoryIF levelFactory;
        Int32 level;
        LibrariesIF library;
        GameShapesIF shape;
        Int32 delaytime;
        String[] words = new String[5];
        CancellationTokenSource cts1 = new CancellationTokenSource();
        CancellationTokenSource cts2 = new CancellationTokenSource();
        CancellationTokenSource cts3 = new CancellationTokenSource();
        CancellationTokenSource cts4 = new CancellationTokenSource();
        CancellationTokenSource cts5 = new CancellationTokenSource();
        public WordBlasterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text.Equals(words[0]))
            {
                cts1.Cancel();
                IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) + level).ToString();
                cts1 = new CancellationTokenSource();
                Lane1Play(cts1.Token);
                InputTextBox.Text = "";
            }
            else if (InputTextBox.Text.Equals(words[1]))
            {
                cts2.Cancel();
                IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) + level).ToString();
                cts2 = new CancellationTokenSource();
                Lane2Play(cts2.Token);
                InputTextBox.Text = "";
            }
            else if (InputTextBox.Text.Equals(words[2]))
            {
                cts3.Cancel();
                IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) + level).ToString();
                cts3 = new CancellationTokenSource();
                Lane3Play(cts3.Token);
                InputTextBox.Text = "";
            }
            else if (InputTextBox.Text.Equals(words[3]))
            {
                cts4.Cancel();
                IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) + level).ToString();
                cts4 = new CancellationTokenSource();
                Lane4Play(cts4.Token);
                InputTextBox.Text = "";
            }
            else if (InputTextBox.Text.Equals(words[4]))
            {
                cts5.Cancel();
                IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) + level).ToString();
                cts5 = new CancellationTokenSource();
                Lane5Play(cts5.Token);
                InputTextBox.Text = "";
            }
        }

        private void Lane1Panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void StartGamebutton_Click(object sender, EventArgs e)
        {
            StartGamebutton.Enabled= false;
            NewLevel(1);
            Lane1Play(cts1.Token);
            Lane2Play(cts2.Token);
            Lane3Play(cts3.Token);
            Lane4Play(cts4.Token);
            Lane5Play(cts5.Token);
        }

        private async void Lane1Play(CancellationToken token)
        {
            words[0] = library.generateWord(); //Generates a word from the Library
            for (int i = 0; i < 760; i++)
            {
                try
                {
                    Lane1Panel.Refresh();
                    Graphics dc = Lane1Panel.CreateGraphics();
                    shape.DrawShape(dc, i, words[0]);
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(delaytime, token); //Delays the task from happening again for a second
                }
                catch(Exception e)
                {
                    words[0] = null;
                    break; //break here because task won't end for a while if you exit the application before finishing
                }
                if (i.Equals(759))
                {
                    IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) - level).ToString();
                }
            }
            words[0] = null;
            this.checkIfLost();
        }

        private async void Lane2Play(CancellationToken token)
        {
            words[1] = library.generateWord(); //Generates a word from the Library
            for (int i = 0; i < 760; i++)
            {
                try
                {
                    Lane2Panel.Refresh();
                    Graphics dc = Lane2Panel.CreateGraphics();
                    shape.DrawShape(dc, i, words[1]);
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(delaytime, token); //Delays the task from happening again for a second
                }
                catch (Exception e)
                {
                    words[1] = null;
                    break; //break here because task won't end for a while if you exit the application before finishing
                }
                if (i.Equals(759))
                {
                    IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) - level).ToString();
                }
            }
            words[1] = null;
            this.checkIfLost();
        }

        private async void Lane3Play(CancellationToken token)
        {
            words[2] = library.generateWord(); //Generates a word from the Library
            for (int i = 0; i < 760; i++)
            {
                try
                {
                    Lane3Panel.Refresh();
                    Graphics dc = Lane3Panel.CreateGraphics();
                    shape.DrawShape(dc, i, words[2]);
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(delaytime, token); //Delays the task from happening again for a second
                }
                catch (Exception e)
                {
                    words[2] = null;
                    break; //break here because task won't end for a while if you exit the application before finishing
                }
                if (i.Equals(759))
                {
                    IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) - level).ToString();
                }
            }
            words[2] = null;
            this.checkIfLost();
        }

        private async void Lane4Play(CancellationToken token)
        {
            words[3] = library.generateWord(); //Generates a word from the Library
            CancellationTokenSource cts = new CancellationTokenSource();
            for (int i = 0; i < 760; i++)
            {
                try
                {
                    Lane4Panel.Refresh();
                    Graphics dc = Lane4Panel.CreateGraphics();
                    shape.DrawShape(dc, i, words[3]);
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(delaytime, token); //Delays the task from happening again for a second
                }
                catch (Exception e)
                {
                    words[3] = null;
                    break; //break here because task won't end for a while if you exit the application before finishing
                }
                if (i.Equals(759))
                {
                    IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) - level).ToString();
                }
            }
            words[3] = null;
            this.checkIfLost();
        }

        private async void Lane5Play(CancellationToken token)
        {
            words[4] = library.generateWord(); //Generates a word from the Library
            CancellationTokenSource cts = new CancellationTokenSource();
            for (int i = 0; i < 760; i++)
            {
                try
                {
                    Lane5Panel.Refresh();
                    Graphics dc = Lane5Panel.CreateGraphics();
                    shape.DrawShape(dc, i, words[4]);
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(delaytime, token); //Delays the task from happening again for a second
                }
                catch (Exception e)
                {
                    words[4] = null;
                    break; //break here because task won't end for a while if you exit the application before finishing
                }
                if (i.Equals(759))
                {
                    IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) - level).ToString();
                }
            }
            words[4] = null;
            this.checkIfLost();
        }

        private void NewLevel(int level)
        {
            this.level = level;
            levelFactory = FactoryProducer.getFactory(level); //Get the factory for the level
            library = levelFactory.createLibrary(); //Creates Library Associated with LevelLibrary
            String word = library.generateWord(); //Generates a word from LevelLibrary
            shape = levelFactory.createShape(); //Creates the Shape and color of shape for level
            IntLevelLabel.Text = level.ToString();
            switch (level)
            {
                case 1:
                    delaytime = 35;
                    break;
                case 2:
                    delaytime = 20;
                    break;
                case 3:
                    delaytime = 10;
                    break;
                case 4:
                    delaytime = 5;
                    break;
                case 5:
                    delaytime = 1;
                    break;
            }
        }

        private void checkIfLost()
        {
            if(words[0] == (null) && words[1] == (null) && words[2]==(null) && words[3]==(null) && words[4]==(null))
            {
                Console.WriteLine("You lost!!");
            }
        }
        private void WordBlasterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
