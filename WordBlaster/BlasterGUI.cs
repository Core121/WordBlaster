using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordBlaster.AbstractFactory;
using WordBlaster.Dynamic_Linkage;
using WordBlaster.Filter;
using WordBlaster.Libraries;
using WordBlaster.Observer;
using WordBlaster.Shapes;

namespace WordBlaster
{
    public partial class WordBlasterForm : Form, ObservableIF
    {
        //Will be the same for each lane
        private FactoryIF levelFactory;
        private Int32 level;
        private LibrariesIF library;
        private GameShapesIF shape;
        private Int32 delaytime;
        private String[] words = new String[5];
        private CancellationTokenSource[] cts = new CancellationTokenSource[5];
        private List<ObserverIF> observers = new List<ObserverIF>();
        private FilterIF[] filters = new FilterIF[2];

        public WordBlasterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void EnterButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Music\\Blast.wav";

            if (InputTextBox.Text.Equals(words[0]))
            {
                cts[0].Cancel();
                await Task.Delay(1); //makes sure the task has time to end before another is started, fixes null word issue
                IncrementScore();
                cts[0] = new CancellationTokenSource();
                Lane1Play(cts.ElementAt(0).Token);
            }
            else if (InputTextBox.Text.Equals(words[1]))
            {
                cts[1].Cancel();
                await Task.Delay(1);//makes sure the task has time to end before another is started, fixes null word issue
                IncrementScore();
                cts[1] = new CancellationTokenSource();
                Lane2Play(cts[1].Token);
            }
            else if (InputTextBox.Text.Equals(words[2]))
            {
                cts[2].Cancel();
                await Task.Delay(1);//makes sure the task has time to end before another is started, fixes null word issue
                IncrementScore();
                cts[2] = new CancellationTokenSource();
                Lane3Play(cts[2].Token);
            }
            else if (InputTextBox.Text.Equals(words[3]))
            {
                cts[3].Cancel();
                await Task.Delay(1);//makes sure the task has time to end before another is started, fixes null word issue
                IncrementScore();
                cts[3] = new CancellationTokenSource();
                Lane4Play(cts[3].Token);
            }
            else if (InputTextBox.Text.Equals(words[4]))
            {
                cts[4].Cancel();
                await Task.Delay(1);//makes sure the task has time to end before another is started, fixes null word issue
                IncrementScore();
                cts[4] = new CancellationTokenSource();
                Lane5Play(cts[4].Token);
            }
            this.InputTextBox.Text = "";
            this.checkScore(); //Check to see if it's time to go to the next level
        }

        private void Lane1Panel_Paint(object sender, PaintEventArgs e)
        {
            /*
            Image img = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\Space.jpg");
            e.Graphics.DrawImage(img, new Point(0, 0));
            */

            //**WARNING** Only uncomment to garuntee seizures during gameplay
        }

        private void StartGamebutton_Click(object sender, EventArgs e)
        {
            StartGamebutton.Enabled= false;
            LoadLevelbutton.Enabled = false;
            RemoveLettercheckBox.Enabled = false;
            ReverseWordcheckBox.Enabled = false;
            this.IntScoreLabel.Text = "0";
            this.StopGameButton.Enabled = true;
            NewLevel(1);
            Lane1Play(cts[0].Token);
            Lane2Play(cts[1].Token);
            Lane3Play(cts[2].Token);
            Lane4Play(cts[3].Token);
            Lane5Play(cts[4].Token);
            InputTextBox.Focus();
        }

        private async void Lane1Play(CancellationToken token)
        {
            words[0] = library.generateWord(); //Generates a word from the Library
            String data = this.filterProcessor(words[0]);
            for (int i = 0; i < 760; i++)
            {
                try
                {
                    Lane1Panel.Refresh();
                    Graphics dc = Lane1Panel.CreateGraphics();
                    shape.DrawShape(dc, i, data);
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
                    Font font = new Font("Arial", 10, FontStyle.Bold);
                    System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    this.Lane1Panel.Refresh();
                    Graphics dc = Lane1Panel.CreateGraphics();
                    dc.DrawString("LANE ENDED.", font, myBrush, new Point(340, 30));
                    words[0] = null;
                    this.checkIfLost();
                }
            }
        }

        private async void Lane2Play(CancellationToken token)
        {
            words[1] = library.generateWord(); //Generates a word from the Library
            String data = this.filterProcessor(words[1]);
            for (int i = 0; i < 760; i++)
            {
                try
                {
                    Lane2Panel.Refresh();
                    Graphics dc = Lane2Panel.CreateGraphics();
                    shape.DrawShape(dc, i, data);
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
                    Font font = new Font("Arial", 10, FontStyle.Bold);
                    System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    this.Lane2Panel.Refresh();
                    Graphics dc = Lane2Panel.CreateGraphics();
                    dc.DrawString("LANE ENDED.", font, myBrush, new Point(340, 30));
                    words[1] = null;
                    this.checkIfLost();
                }
            }
        }

        private async void Lane3Play(CancellationToken token)
        {
            words[2] = library.generateWord(); //Generates a word from the Library
            String data = this.filterProcessor(words[2]);
            for (int i = 0; i < 760; i++)
            {
                try
                {
                    Lane3Panel.Refresh();
                    Graphics dc = Lane3Panel.CreateGraphics();
                    shape.DrawShape(dc, i, data);
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
                    Font font = new Font("Arial", 10, FontStyle.Bold);
                    System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    this.Lane3Panel.Refresh();
                    Graphics dc = Lane3Panel.CreateGraphics();
                    dc.DrawString("LANE ENDED.", font, myBrush, new Point(340, 30));
                    words[2] = null;
                    this.checkIfLost();
                }
            }
        }

        private async void Lane4Play(CancellationToken token)
        {
            words[3] = library.generateWord(); //Generates a word from the Library
            String data = this.filterProcessor(words[3]);
            for (int i = 0; i < 760; i++)
            {
                try
                {
                    Lane4Panel.Refresh();
                    Graphics dc = Lane4Panel.CreateGraphics();
                    shape.DrawShape(dc, i, data);
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
                    Font font = new Font("Arial", 10, FontStyle.Bold);
                    System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    this.Lane4Panel.Refresh();
                    Graphics dc = Lane4Panel.CreateGraphics();
                    dc.DrawString("LANE ENDED.", font, myBrush, new Point(340, 30));
                    words[3] = null;
                    this.checkIfLost();
                }
            }
        }

        private async void Lane5Play(CancellationToken token)
        {
            words[4] = library.generateWord(); //Generates a word from the Library
            String data = this.filterProcessor(words[4]);
            for (int i = 0; i < 760; i++)
            {
                try
                {
                    Lane5Panel.Refresh();
                    Graphics dc = Lane5Panel.CreateGraphics();
                    shape.DrawShape(dc, i, data);
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(delaytime, token); //Delays the task from happening again for a second
                }
                catch (OperationCanceledException e)
                {
                    words[4] = null;
                    break; //break here because task won't end for a while if you exit the application before finishing
                }
                if (i.Equals(759))
                {
                    Font font = new Font("Arial", 10, FontStyle.Bold);
                    System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    this.Lane5Panel.Refresh();
                    Graphics dc = Lane5Panel.CreateGraphics();
                    dc.DrawString("LANE ENDED.", font, myBrush, new Point(340, 30));
                    words[4] = null;
                    this.checkIfLost();
                }
            }
        }

        public void NewLevel(int level)
        {
            FactoryProducer factoryProducer = new FactoryProducer();
            levelFactory = factoryProducer.getFactory(level); //Get the factory for the level
            library = levelFactory.createLibrary(); //Creates Library Associated with LevelLibrary
            String word = library.generateWord(); //Generates a word from LevelLibrary
            shape = levelFactory.createShape(); //Creates the Shape and color of shape for level
            delaytime = levelFactory.getDelay();
            this.level = levelFactory.getLevel(); //Only needed for if dynamic linkage doesnt work, makes sure to get the true level
            IntLevelLabel.Text = this.level.ToString();
        }

        private void checkIfLost()
        {
            if(words[0] == (null) && words[1] == (null) && words[2]==(null) && words[3]==(null) && words[4]==(null))
            {
                MessageBox.Show("You lost!\nScore: " + this.IntScoreLabel.Text + "\nLevel: " + IntLevelLabel.Text);
                StartGamebutton.Enabled = true;
                ReverseWordcheckBox.Enabled = true;
                RemoveLettercheckBox.Enabled = true;
                LoadLevelbutton.Enabled = true;
                StopGameButton.Enabled = false;
            }
        }

        private void WordBlasterForm_Load(object sender, EventArgs e)
        {
            cts[0] = (new CancellationTokenSource());
            cts[1] = (new CancellationTokenSource());
            cts[2] = (new CancellationTokenSource());
            cts[3] = (new CancellationTokenSource());
            cts[4] = (new CancellationTokenSource());
            observers.Add(new ScoreObserver());
            this.StopGameButton.Enabled = false;
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Music\\WordBlasterMusic.wav";
            player.PlayLooping();
        }

        public async void stopAllTasks(bool restart) //Stops all the lanes and restarts them
        {
            for(int i = 0; i < cts.Count(); i++)
            {
                cts[i].Cancel();
            }
            await Task.Delay(5); //Awaits for all lanes to cancel
            for (int i = 0; i < cts.Count(); i++)
            {
                cts[i] = new CancellationTokenSource(); //create all new cancellation tokens
            }
            if (restart)
            {
                Lane1Play(cts[0].Token); //restart all lanes
                Lane2Play(cts[1].Token);
                Lane3Play(cts[2].Token);
                Lane4Play(cts[3].Token);
                Lane5Play(cts[4].Token);
            }
        }

        public int getLevel() //returns the current level
        {
            return this.level;
        }

        public void addObserver(ObserverIF observer) //adds on observer to the observer list
        {
            observers.Add(observer);
        }

        public void removeObserver(ObserverIF observer) //removes an observer from the observer list
        {
            observers.Remove(observer);
        }

        private void checkScore() //The levels are determined by the below checks, the observers will be notified upon level change
        {
            if(level.Equals(1) && Convert.ToInt32(IntScoreLabel.Text) >= 20)
            {
                for(int i = 0; i < observers.Count(); i++)
                {
                    observers.ElementAt(i).notify(this);
                }
            }
            else if (level.Equals(2) && Convert.ToInt32(IntScoreLabel.Text) >= 100)
            {
                for (int i = 0; i < observers.Count(); i++)
                {
                    observers.ElementAt(i).notify(this);
                }
            }
            else if (level.Equals(3) && Convert.ToInt32(IntScoreLabel.Text) >= 200)
            {
                for (int i = 0; i < observers.Count(); i++)
                {
                    observers.ElementAt(i).notify(this);
                }
            }
            else if (level.Equals(4) && Convert.ToInt32(IntScoreLabel.Text) >= 320)
            {
                for (int i = 0; i < observers.Count(); i++)
                {
                    observers.ElementAt(i).notify(this);
                }
            }
        }

        private void RemoveLettercheckBox_CheckedChanged(object sender, EventArgs e) //To add or remove the filter from the array
        {
            if (RemoveLettercheckBox.Checked == true)
            {
                RandomFilter Randfilt = new RandomFilter();
                filters[0] = Randfilt;
            }
            else
            {
                for (int i = 0; i < filters.Count(); i++)
                {
                    filters[0] = null;
                }
            }
        }

        private void ReverseWordcheckBox_CheckedChanged(object sender, EventArgs e) //To add or remove the filter from the array
        {
            ReverseFilter Revfilt = new ReverseFilter(); ;
            if (ReverseWordcheckBox.Checked == true)
            {
                filters[1] = Revfilt;
            }
            else
            {
                filters[1] = null;
            }
        }



        private string filterProcessor(String data) //Goes through and see if there are any filters in the array, if there are filter out the data
        {
            for(int i = 0; i < filters.Count(); i++)
            {
                if (filters[i] != null)
                {
                    data = filters[i].Filter(data);
                }
            }
            return data;
        }

        private void IncrementScore() //Increments the score and rewards more when more filters are applied
        {
            if (this.ReverseWordcheckBox.Checked == true && this.RemoveLettercheckBox.Checked == true)
            {
                IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) + (level * 3)).ToString();
            }
            else if(this.ReverseWordcheckBox.Checked == true || this.RemoveLettercheckBox.Checked == true)
            {
                IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) + (level * 2)).ToString();
            }
            else
            {
                IntScoreLabel.Text = (Convert.ToInt32(this.IntScoreLabel.Text) + level).ToString();
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadLevelbutton_Click(object sender, EventArgs e)
        {
            LevelPlayer player = LevelPlayer.getInstance();
            player.getDynamicFile();
            StartGamebutton.Enabled = false;
            LoadLevelbutton.Enabled = false;
            RemoveLettercheckBox.Enabled = false;
            ReverseWordcheckBox.Enabled = false;
            this.IntScoreLabel.Text = "0";
            NewLevel(6);
            Lane1Play(cts[0].Token);
            Lane2Play(cts[1].Token);
            Lane3Play(cts[2].Token);
            Lane4Play(cts[3].Token);
            Lane5Play(cts[4].Token);
            InputTextBox.Focus();
        }

        private void IntScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private async void StopGameButton_Click(object sender, EventArgs e)
        {
            this.stopAllTasks(false);
            await Task.Delay(2);
            this.Lane1Panel.Refresh();
            this.Lane2Panel.Refresh();
            this.Lane3Panel.Refresh();
            this.Lane4Panel.Refresh();
            this.Lane5Panel.Refresh();
            this.checkIfLost();
        }
    }
}
