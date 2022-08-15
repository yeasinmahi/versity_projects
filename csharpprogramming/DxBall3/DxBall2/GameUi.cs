using System;
using System.Drawing;
using System.Windows.Forms;

namespace DxBall2
{
    public partial class GameUi : Form
    {
        readonly Timer _timer;
        Point _barLocation;
        Point _ballLocation;
        Point _obstrucleLocation;
        Rectangle _screenRectangle;
        bool _run = true;
        readonly PictureBox[] _pictureBoxs;
        readonly Point[] _locationsOfPictureBoxs;

        int s = 5, t = -5;
        int _life = 3, _score = 0;
        int _count = 0;

        private void Reset()
        {
            s = 5;
            t = -5;
            ballOvalShape.Location = new Point(290, 410);
            barPictureBox.Location = new Point(255, 470);
            _timer.Stop();
            _timer.Enabled = false;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyValue == 37)  //Left key
            {
                _barLocation = barPictureBox.Location;
                if (_barLocation.X >= _screenRectangle.Left)
                {
                    _barLocation.X -= 15;
                    barPictureBox.Location = new Point(_barLocation.X, _barLocation.Y);
                }
            }
            if (e.KeyValue == 39) //Right key
            {
                _barLocation = barPictureBox.Location;
                if (_barLocation.X < _screenRectangle.Right - 120)
                {
                    _barLocation.X += 15;
                    barPictureBox.Location = new Point(_barLocation.X, _barLocation.Y);
                }
            }
            if (e.KeyValue == 32) //Space key
            {
                if (_run)
                {
                    _timer.Start();
                    _timer.Enabled = true;
                    _run = false;

                }

                else
                {
                    _timer.Stop();
                    _timer.Enabled = false;
                    _run = true;
                }
            }
            if (e.KeyValue == 8) //Back Key
            {
                Close();
                MainUi formGame = new MainUi();
                formGame.Visible = true;
            }
        }

        public GameUi()
        {
            InitializeComponent();
            _barLocation = barPictureBox.Location;
            _ballLocation = ballOvalShape.Location;
            _screenRectangle = new Rectangle(0, 0, 600, 480);
            _timer = new Timer();
            _timer.Interval = 50;
            _timer.Tick += timer_Tick;
            _locationsOfPictureBoxs = new Point[70];
            _pictureBoxs = new PictureBox[70];
            _pictureBoxs[0] = pictureBox2;
            _pictureBoxs[1] = pictureBox3;
            _pictureBoxs[2] = pictureBox4;
            _pictureBoxs[3] = pictureBox5;
            _pictureBoxs[4] = pictureBox9;
            _pictureBoxs[5] = pictureBox8;
            _pictureBoxs[6] = pictureBox7;
            _pictureBoxs[7] = pictureBox6;
            _pictureBoxs[8] = pictureBox17;
            _pictureBoxs[9] = pictureBox16;
            _pictureBoxs[10] = pictureBox15;
            _pictureBoxs[11] = pictureBox14;
            _pictureBoxs[12] = pictureBox13;
            _pictureBoxs[13] = pictureBox12;
            _pictureBoxs[14] = pictureBox11;
            _pictureBoxs[15] = pictureBox10;
            _pictureBoxs[16] = pictureBox32;
            _pictureBoxs[17] = pictureBox31;
            _pictureBoxs[18] = pictureBox30;
            _pictureBoxs[19] = pictureBox29;
            _pictureBoxs[20] = pictureBox28;
            _pictureBoxs[21] = pictureBox27;
            _pictureBoxs[22] = pictureBox26;
            _pictureBoxs[23] = pictureBox25;
            _pictureBoxs[24] = pictureBox24;
            _pictureBoxs[25] = pictureBox23;
            _pictureBoxs[26] = pictureBox22;
            _pictureBoxs[27] = pictureBox21;
            _pictureBoxs[28] = pictureBox20;
            _pictureBoxs[29] = pictureBox19;
            _pictureBoxs[30] = pictureBox18;
            _pictureBoxs[31] = pictureBox47;
            _pictureBoxs[32] = pictureBox46;
            _pictureBoxs[33] = pictureBox45;
            _pictureBoxs[34] = pictureBox44;
            _pictureBoxs[35] = pictureBox43;
            _pictureBoxs[36] = pictureBox42;
            _pictureBoxs[37] = pictureBox41;
            _pictureBoxs[38] = pictureBox40;
            _pictureBoxs[39] = pictureBox39;
            _pictureBoxs[40] = pictureBox38;
            _pictureBoxs[41] = pictureBox37;
            _pictureBoxs[42] = pictureBox36;
            _pictureBoxs[43] = pictureBox35;
            _pictureBoxs[44] = pictureBox34;
            _pictureBoxs[45] = pictureBox59;
            _pictureBoxs[46] = pictureBox58;
            _pictureBoxs[47] = pictureBox57;
            _pictureBoxs[48] = pictureBox56;
            _pictureBoxs[49] = pictureBox55;
            _pictureBoxs[50] = pictureBox54;
            _pictureBoxs[51] = pictureBox53;
            _pictureBoxs[52] = pictureBox52;
            _pictureBoxs[53] = pictureBox51;
            _pictureBoxs[54] = pictureBox50;
            _pictureBoxs[55] = pictureBox49;
            _pictureBoxs[56] = pictureBox48;
            _pictureBoxs[57] = pictureBox33;
            _pictureBoxs[58] = pictureBox71;
            _pictureBoxs[59] = pictureBox70;
            _pictureBoxs[60] = pictureBox69;
            _pictureBoxs[61] = pictureBox68;
            _pictureBoxs[62] = pictureBox67;
            _pictureBoxs[63] = pictureBox66;
            _pictureBoxs[64] = pictureBox65;
            _pictureBoxs[65] = pictureBox64;
            _pictureBoxs[66] = pictureBox63;
            _pictureBoxs[67] = pictureBox62;
            _pictureBoxs[68] = pictureBox61;
            _pictureBoxs[69] = pictureBox60;
            foreach (Point locate in _locationsOfPictureBoxs)
            {
                _locationsOfPictureBoxs[_count] = _pictureBoxs[_count].Location;
                _count++;
            }

        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (_life > 0)
            {
                MoveBall();
            }
            else
            {
                _timer.Stop();
                _timer.Enabled = false;
            }
        }

        void MoveBall()
        {
            _ballLocation = ballOvalShape.Location;
            CheckComplictWithPictureBox();

            CheckComplictWithBar();

            CheckComplictWithScreen();
            Console.WriteLine("" + _ballLocation.X + "  " + _ballLocation.Y);
        }

        private void CheckComplictWithScreen()
        {
            if (_ballLocation.X <= 0)
            {
                if (t == -5)
                {
                    _ballLocation.X += 5;
                    _ballLocation.Y -= 5;
                    s = 5;
                    t = -5;
                }
                if (t == 5)
                {
                    _ballLocation.X += 5;
                    _ballLocation.Y += 5;
                    s = 5;
                    t = 5;
                }


                ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
            }
            else if (_ballLocation.X >= 585)
            {
                if (t == -5)
                {
                    _ballLocation.X -= 5;
                    _ballLocation.Y -= 5;
                    s = -5;
                    t = -5;
                }
                if (t == 5)
                {
                    _ballLocation.X -= 5;
                    _ballLocation.Y += 5;
                    s = -5;
                    t = 5;
                }
                ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
            }
            else if (_ballLocation.Y <= 0)
            {
                if (s == 5)
                {
                    _ballLocation.X += 5;
                    _ballLocation.Y += 5;
                    s = 5;
                    t = 5;
                }
                if (s == -5)
                {
                    _ballLocation.X -= 5;
                    _ballLocation.Y += 5;
                    s = -5;
                    t = 5;
                }
                ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
            }
            else if (_ballLocation.Y >= 480)
            {
                _life--;
                LifeLabel.Text = Convert.ToString(_life);
                Reset();
            }
            else
            {
                _ballLocation.X += s;
                _ballLocation.Y += t;
                ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
            }
        }

        private void CheckComplictWithBar()
        {
            if (_ballLocation.X >= _barLocation.X - 15 && _ballLocation.X <= _barLocation.X + 115 &&
                _ballLocation.Y >= _barLocation.Y - 30)
            {
                if (_ballLocation.X >= _barLocation.X - 15 && _ballLocation.X <= _barLocation.X + 5 && s == 5)
                {
                    _ballLocation.X -= 5;
                    _ballLocation.Y -= 5;
                    s = -5;
                    t = -5;
                }
                if (_ballLocation.X <= _barLocation.X + 100 && _ballLocation.X >= _barLocation.X + 70 && s == -5)
                {
                    _ballLocation.X += 5;
                    _ballLocation.Y -= 5;
                    s = 5;
                    t = -5;
                }
                if (s == -5)
                {
                    _ballLocation.X -= 5;
                    _ballLocation.Y -= 5;
                    s = -5;
                    t = -5;
                }
                if (s == 5)
                {
                    _ballLocation.X += 5;
                    _ballLocation.Y -= 5;
                    s = 5;
                    t = -5;
                }
                ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
            }
        }

        private void CheckComplictWithPictureBox()
        {
            _count = -1;
            foreach (Point locate in _locationsOfPictureBoxs)
            {
                _count++;
                _obstrucleLocation = _locationsOfPictureBoxs[_count];
                if (_ballLocation.X + 15 >= _obstrucleLocation.X && _ballLocation.X <= _obstrucleLocation.X + 25 &&
                    _ballLocation.Y + 15 >= _obstrucleLocation.Y && _ballLocation.Y <= _obstrucleLocation.Y + 15)
                {
                    if (_ballLocation.Y <= _obstrucleLocation.Y + 5)
                    {
                        if (s == 5)
                        {
                            _ballLocation.X += 5;
                            _ballLocation.Y -= 5;
                            s = 5;
                            t = -5;
                            Direction();
                            ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
                            break;
                        }
                        if (s == -5)
                        {
                            _ballLocation.X -= 5;
                            _ballLocation.Y -= 5;
                            s = -5;
                            t = -5;
                            Direction();
                            ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
                            break;
                        }
                    }
                    if (_ballLocation.Y >= _obstrucleLocation.Y + 10)
                    {
                        if (s == 5)
                        {
                            _ballLocation.X += 5;
                            _ballLocation.Y += 5;
                            s = 5;
                            t = 5;
                            Direction();
                            ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
                            break;
                        }
                        if (s == -5)
                        {
                            _ballLocation.X -= 5;
                            _ballLocation.Y += 5;
                            s = -5;
                            t = 5;
                            Direction();
                            ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
                            break;
                        }
                    }
                    if (_ballLocation.X <= _obstrucleLocation.X + 5)
                    {
                        if (t == -5)
                        {
                            _ballLocation.X -= 5;
                            _ballLocation.Y -= 5;
                            s = -5;
                            t = -5;
                            Direction();
                            ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
                            break;
                        }
                        if (t == 5)
                        {
                            _ballLocation.X -= 5;
                            _ballLocation.Y += 5;
                            s = -5;
                            t = 5;
                            Direction();
                            ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
                            break;
                        }
                    }
                    if (_ballLocation.X >= _obstrucleLocation.X + 20)
                    {
                        if (t == -5)
                        {
                            _ballLocation.X += 5;
                            _ballLocation.Y -= 5;
                            s = 5;
                            t = -5;
                            Direction();
                            ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
                            break;
                        }
                        if (t == 5)
                        {
                            _ballLocation.X += 5;
                            _ballLocation.Y += 5;
                            s = 5;
                            t = 5;
                            Direction();
                            ballOvalShape.Location = new Point(_ballLocation.X, _ballLocation.Y);
                            break;
                        }
                    }
                }
            }
            _count = 0;
        }

        void Direction()
        {
            _score += 5;
            ScoreLabel.Text = Convert.ToString(_score);
            Controls.Remove(_pictureBoxs[_count]);
            _pictureBoxs[_count].Visible = false;
            _locationsOfPictureBoxs[_count] = new Point(-5, -5);
        }
    }
}