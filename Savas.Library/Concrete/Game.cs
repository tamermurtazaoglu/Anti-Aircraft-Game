using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Savas.Library.Concrete
{
    public class Game : IGame
    {
        #region Fields
        private readonly Timer _elapsedTimeTimer = new Timer { Interval = 1000 };
        private readonly Timer _moveTimer = new Timer { Interval = 25 };
        private readonly Timer _aircraftCreateTimer = new Timer { Interval = 2000 };
        private TimeSpan _elapsedTime;
        private readonly Panel _antiaircraftPanel;
        private Antiaircraft _antiaircraft;
        private int _score;
        private int _health = 100;
        private string _level;
        private readonly Panel _warareaPanel;
        private readonly Panel _infoPanel;
        private readonly List<Bullet> _bullets = new List<Bullet>();
        private readonly List<Aircraft> _aircrafts = new List<Aircraft>();
        private bool _isPaused = false;
        private int _scoreToBeEarned;
        #endregion

        #region Events
        public event EventHandler ElapsedTimeChanged;
        #endregion

        #region Properties

        public bool DoesItContinue { get; private set; }
        public TimeSpan ElapsedTime {
            get => _elapsedTime;
            private set
            {
                _elapsedTime = value;
                ElapsedTimeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public int Score {
            get => _score;
            private set => _score += value;
        }

        public int Health
        {
            get => _health;
            private set
            {
                int health = _health + value;
                _health = (health<=0) ? 0 : _health + value;
            }
        }

        public string Level
        {
            get => _level;
            private set => _level = value;
        }

        public bool IsPaused {
            get => _isPaused;
            set => _isPaused = value;
        }


        public void SetDifficulty(int difficulty)
        {
            switch (difficulty)
            {
                case 2:
                    _moveTimer.Enabled = false;
                    _moveTimer.Interval = 20;
                    _aircraftCreateTimer.Interval = 1500;
                    _moveTimer.Enabled = true;
                    _scoreToBeEarned = 100;
                    Level = "2";
                    
                    break;
                case 3:
                    _moveTimer.Enabled = false;
                    _moveTimer.Interval =  15;
                    _moveTimer.Enabled = true;
                    _aircraftCreateTimer.Enabled = false;
                    _aircraftCreateTimer.Interval = 1000;
                    _aircraftCreateTimer.Enabled = true;
                    _scoreToBeEarned = 500;
                    Level = "3";
                    break;
                default:
                    break;
            }
        }



        #endregion

        #region Methods
        public Game(Panel antiaircraftPanel, Panel warareaPanel, Panel infoPanel, string level, string difficulty="Normal")
        {
            _antiaircraftPanel = antiaircraftPanel;
            _warareaPanel = warareaPanel;
            _infoPanel = infoPanel;
            _level = level;
            _elapsedTimeTimer.Tick += ElapsedTimeTimer_Tick;
            _moveTimer.Tick += MoveTimer_Tick;
            _aircraftCreateTimer.Tick += AircraftCreateTimer_Tick;
            _scoreToBeEarned = 50;
            var infoLabel = _infoPanel.Controls.Find("infoLabel", true).FirstOrDefault();
            infoLabel.Text = "Press \"Enter\" to start game\n" +
                "< > to move.  \"Space\" to fire.\n" +
                "Press P to pause";

        }
        

        private void ElapsedTimeTimer_Tick(object sender, EventArgs e)
        {
            if (IsPaused) return;
            ElapsedTime += TimeSpan.FromSeconds(1);
            
            
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            if (IsPaused) return;
            MoveBullets();
            MoveAirCrafts();
            DeleteAircrafts("killed");
        }


        public void PauseOrContinue()
        {
            if (IsPaused == false)
            {
                IsPaused = true;
            }
            else
            {
                IsPaused = false;
            }
        }

        private void DeleteAircrafts(string which="killed")
        {
            if(which=="killed")
            {
                for (var i = _aircrafts.Count - 1; i >= 0; i--)
                {
                    var aircraft = _aircrafts[i];

                    var bulletThatShotIt = aircraft.BulletThatShotIt(_bullets);
                    if (bulletThatShotIt is null) continue;

                    _aircrafts.Remove(aircraft);
                    _warareaPanel.Controls.Remove(aircraft);
                    _bullets.Remove(bulletThatShotIt);
                    _warareaPanel.Controls.Remove(bulletThatShotIt);

                    Score = _scoreToBeEarned;
                    IncreaseScore();
                    Health = 1;
                    ShowHealth();
                }
            }
            else if(which=="all")
            {
                for (var i = _aircrafts.Count - 1; i >= 0; i--)
                {
                    var aircraft = _aircrafts[i];
                    _aircrafts.Remove(aircraft);
                    _warareaPanel.Controls.Remove(aircraft);
                }
            }

        }

        private void DeleteAllGameObjects()
        {
            for (var i = _aircrafts.Count - 1; i >= 0; i--)
            {
                var aircraft = _aircrafts[i];
                _aircrafts.Remove(aircraft);
                _warareaPanel.Controls.Remove(aircraft);
            }
            for (var i = _bullets.Count - 1; i >= 0; i--)
            {
                var bullet = _bullets[i];
                _bullets.Remove(bullet);
                _warareaPanel.Controls.Remove(bullet);
            }
            _antiaircraftPanel.Controls.Remove(_antiaircraft);
        }

        private void IncreaseScore()
        {
            var scoreLabel = _infoPanel.Controls.Find("scoreLabel", true).FirstOrDefault();
            scoreLabel.Text = Score.ToString();
        }

        private void MoveAirCrafts()
        {
            foreach (var aircraft in _aircrafts)
            {
                var didHitToBottom = aircraft.Move(Direction.Down);
                if (!didHitToBottom) continue;
                _aircrafts.Remove(aircraft);
                _warareaPanel.Controls.Remove(aircraft);
                Health = -10;
                if (Health <= 0) {
                    Finish();
                }
                ShowHealth();
                break;
            }
        }

        private void ShowHealth()
        {
            var healthLabel = _infoPanel.Controls.Find("healthLabel", true).FirstOrDefault();
            healthLabel.Text = Health.ToString();
        }

        private void AircraftCreateTimer_Tick(object sender, EventArgs e)
        {
            CreateAircraft();
        }

        private void MoveBullets()
        {
            for (int i = _bullets.Count -1; i >= 0; i--)
            {
                var bullet = _bullets[i];
                var didHitToTop = bullet.Move(Direction.Up);
                if (didHitToTop)
                {
                    _bullets.Remove(bullet);
                    _warareaPanel.Controls.Remove(bullet);
                }
            }
        }

        public void Fire()
        {
            if (!DoesItContinue) return;
            
            var bullet = new Bullet(_warareaPanel.Size, _antiaircraft.Center);
            _bullets.Add(bullet);
            _warareaPanel.Controls.Add(bullet);
        }

        public void MoveAntiaircraft(Direction direction)
        {
            if (!DoesItContinue) return;
            _antiaircraft.Move(direction);
        }

        public void Start()
        {
            if (DoesItContinue) return;
            DoesItContinue = true;
            StartTimers();

            Create_AntiAircraft();
            CreateAircraft();
            ShowHealth();
            ShowScore();
            
        }

        private void ShowScore()
        {
            var scoreLabel = _infoPanel.Controls.Find("scoreLabel", true).FirstOrDefault();
            scoreLabel.Text = Score.ToString();
        }

        private void CreateAircraft()
        {
            if (IsPaused) return;
            var aircraft = new Aircraft(_level,_warareaPanel.Size);
            _warareaPanel.Controls.Add(aircraft);
            _aircrafts.Add(aircraft);
        }

        private void StartTimers()
        {
            _elapsedTimeTimer.Start();
            _moveTimer.Start();
            _aircraftCreateTimer.Start();
        }

        private void Create_AntiAircraft()
        {
            _antiaircraft = new Antiaircraft(_antiaircraftPanel.Width, _antiaircraftPanel.Size);
            _antiaircraftPanel.Controls.Add(_antiaircraft);
        }

        private void Finish()
        {
            if (!DoesItContinue) return;
            DoesItContinue = false;
            FinishTimers();
            DeleteAllGameObjects();
            changeScoreList();
            ShowGameOver();

        }

        private void ShowGameOver()
        {
            var infoLabel = _infoPanel.Controls.Find("infoLabel", true).FirstOrDefault();
            infoLabel.Text = "Game over.";
            BlinkLabel(infoLabel);

            //_warareaPanel.BackColor = Color.Transparent;
            //_warareaPanel.BackgroundImage = Image.FromFile(@"Images\gameover.gif");
            //_warareaPanel.BackgroundImageLayout = ImageLayout.Center;

            //PictureBox gameOverPicture = new PictureBox
            //{
            //    Name = "gameoverPicturebox",
            //    Image = Image.FromFile(@"Images\gameover.gif")
            //};

            //_warareaPanel.Controls.Add(gameOverPicture);


            // "Press 'Enter' to start game"
            //infoLabel.BackgroundImage = Image.FromFile(@"Images\gameoverback.gif");
            //infoLabel.BackColor = Color.Transparent;
            //infoLabel.BackgroundImageLayout = ImageLayout.Center;

            //infoLabel.Font = new Font(infoLabel.Font, FontStyle.Bold);
        }

        private async void BlinkLabel(Control label)
        {
            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(500);
                label.Visible = (label.Visible == true) ? false : true;
            }
        }

        private void FinishTimers()
        {
            _elapsedTimeTimer.Stop();
            _moveTimer.Stop();
            _aircraftCreateTimer.Stop();
        }

        private void changeScoreList()
        {
            string fileLocation = @"score.txt";

            if (!File.Exists(fileLocation))
            {
                FileStream fs = new FileStream(fileLocation, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("0\n0\n0\n0\n0");
                sw.Flush();
                sw.Close();
                fs.Close();
            }



            //string allScores = File.ReadAllText(fileLocation, Encoding.UTF8);
            //string allScoresWithNewScore = content + "\n" + Score.ToString();

            string[] scores = File.ReadAllLines(fileLocation, Encoding.UTF8);

            List<int> newScores = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                newScores.Add(Convert.ToInt32(scores[i]));
            }

            newScores.Sort();

            for (int i = 0; i < 5; i++)
            {
                if(Score>Convert.ToInt32(scores[i]))
                {
                    newScores[0] = Score;

                    newScores.Sort();

                    String lastScores = newScores[4].ToString() + "\n" +
                                    newScores[3].ToString() + "\n" +
                                    newScores[2].ToString() + "\n" +
                                    newScores[1].ToString() + "\n" +
                                    newScores[0].ToString() + "\n";


                    File.WriteAllText(fileLocation, lastScores);

                    break;
                }
            }

            MessageBox.Show(newScores[4].ToString() + "\n" +
                  newScores[3].ToString() + "\n" +
                  newScores[2].ToString() + "\n" +
                  newScores[1].ToString() + "\n" +
                  newScores[0].ToString() + "\n",
                  "Top 5 Score List");



            //sw.Write(sr.ReadToEnd());
            //sw.Write(Score);

            //sw.Flush();



            //string score = sr.ReadLine();
            //for (int i = 0; i < 5; i++)
            //{
            //    if(score != null && score != "")
            //    {
            //        scores[i] = (Convert.ToInt32(score));
            //    }
            //    score = sr.ReadLine();
            //}

            //sw.Close();
            //sr.Close();
            //fs.Close();

            ////scores.Sort();
            //MessageBox.Show(scores[0].ToString() + "\n" + 
            //                scores[1].ToString() + "\n" +
            //                scores[2].ToString() + "\n" +
            //                scores[3].ToString() + "\n" +
            //                scores[4].ToString() + "\n" );
        }



        #endregion


    }
}
