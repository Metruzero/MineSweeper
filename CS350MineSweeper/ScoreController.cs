using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS350MineSweeper
{
    public class Score
    {
        //Attributes
        public string name;
        public Difficulty diff;
        public int time;

        public Score(string n, Difficulty d, int t)
        {
            name = n;
            diff = d;
            time = t;
        }
    }

    class ScoreController
    {

        //Attributes
        private BinaryReader _br;
        private BinaryWriter _bw;
        private string _fileName;
        private List<Score> _easy;
        private List<Score> _medium;
        private List<Score> _hard;
        private const int MaxScores = 5;

        public ScoreController()
        {
            //File name
            _fileName = @"..\scores.bin";

            //Check if file exists
            if (!File.Exists(_fileName))
            {
                _bw = new BinaryWriter(new FileStream(_fileName, FileMode.Create));
                _bw.Close();
            }

            //Declare lists
            _easy = new List<Score>();
            _medium = new List<Score>();
            _hard = new List<Score>();


        }

        public void WriteScores()
        {

            _bw = new BinaryWriter(new FileStream(_fileName, FileMode.Open));

            //Write Easy
            for (int i = 0; i < _easy.Count; i++)
            {
                _bw.Write(_easy[i].name);
                _bw.Write((int)_easy[i].diff);
                _bw.Write(_easy[i].time);
            }

            //Clear easy
            _easy.Clear();

            //Write Medium
            for (int i = 0; i < _medium.Count; i++)
            {
                _bw.Write(_medium[i].name);
                _bw.Write((int)_medium[i].diff);
                _bw.Write(_medium[i].time);
            }

            //Clear medium
            _medium.Clear();

            //Write hard
            for (int i = 0; i < _hard.Count; i++)
            {
                _bw.Write(_hard[i].name);
                _bw.Write((int)_hard[i].diff);
                _bw.Write(_hard[i].time);
            }

            //Clear medium
            _hard.Clear();

            _bw.Close();

        }

        private void LoadScores()
        {
            _br = new BinaryReader(new FileStream(_fileName, FileMode.Open));

            while (true)
            {
                try
                {
                    string s = _br.ReadString();
                    int diff = _br.ReadInt32();
                    int score = _br.ReadInt32();

                    Score tempScore = new Score(s, (Difficulty)diff, score);

                    switch (tempScore.diff)
                    {
                        case Difficulty.Easy:
                            _easy.Add(tempScore);
                            break;
                        case Difficulty.Medium:
                            _medium.Add(tempScore);
                            break;
                        case Difficulty.Hard:
                            _hard.Add(tempScore);
                            break;
                    }
                }
                catch (IOException e)
                {
                    break;
                }
            }

            _br.Close();
        }

        public void AddScore(string name, Difficulty diff, int score)
        {
            //Load Score call
            LoadScores();

            Score tempScore = new Score(name, diff, score);

            switch (tempScore.diff)
            {
                case Difficulty.Easy:
                    _easy.Add(tempScore);
                    break;
                case Difficulty.Medium:
                    _medium.Add(tempScore);
                    break;
                case Difficulty.Hard:
                    _hard.Add(tempScore);
                    break;
            }


            //                      Easy Score Code
            //Sort list by time
            _easy = _easy.OrderBy(s => s.time).ToList<Score>();

            //Check is list needs trimming
            if (_easy.Count > MaxScores)
            {
                trimScores(_easy);
            }


            //                      Medium Score Code
            //Sort list by time
            _medium = _medium.OrderBy(s => s.time).ToList<Score>();

            //Check is list needs trimming
            if (_medium.Count > MaxScores)
            {
                trimScores(_medium);
            }

            //                      Hard Score Code
            //Sort list by time
            _hard = _hard.OrderBy(s => s.time).ToList<Score>();

            //Check is list needs trimming
            if (_hard.Count > MaxScores)
            {
                trimScores(_hard);
            }


            WriteScores();



        }

        private void trimScores(List<Score> list)
        {
            //Loops through all values in the list
            for (int i = list.Count - 1; i >= MaxScores; i--)
            {
                list.RemoveAt(i);
            }
        }

        public bool isHighScore(Difficulty diff, int time)
        {
            //Load scores into lists
            LoadScores();

            bool highScore = false;

            switch (diff)
            {

                //Easy case
                case Difficulty.Easy:
                    //If the easy list has less than 5 scores, then it has room for more high scores
                    if (_easy.Count < MaxScores)
                    {
                        highScore = true;
                    }
                    else
                    {
                        //If the score is less than the highest value, then it is a new high score
                        if (_easy[4].time > time)
                        {
                            highScore = true;
                        }
                        else
                        {
                            highScore = false;
                        }
                    }
                    break;
                //Medium Case
                case Difficulty.Medium:
                    //If the easy list has less than 5 scores, then it has room for more high scores
                    if (_medium.Count < MaxScores)
                    {
                        highScore = true;
                    }
                    else
                    {
                        //If the score is less than the highest value, then it is a new high score
                        if (_medium[4].time > time)
                        {
                            highScore = true;
                        }
                        else
                        {
                            highScore = false;
                        }
                    }
                    break;
                //Hard Case
                case Difficulty.Hard:
                    //If the easy list has less than 5 scores, then it has room for more high scores
                    if (_hard.Count < MaxScores)
                    {
                        highScore = true;
                    }
                    else
                    {
                        //If the score is less than the highest value, then it is a new high score
                        if (_hard[4].time > time)
                        {
                            highScore = true;
                        }
                        else
                        {
                            highScore = false;
                        }
                    }
                    break;
            }//End of switch

            //Clear lists
            _easy.Clear();
            _medium.Clear();
            _hard.Clear();

            return highScore;
        }

        public List<Score> GetScoreList(Difficulty diff)
        {
            //Load scores
            LoadScores();

            List<Score> retScoreList = new List<Score>();

            switch (diff)
            {
                case Difficulty.Easy:
                    retScoreList = new List<Score>(_easy);
                    break;
                case Difficulty.Medium:
                    retScoreList = new List<Score>(_medium);
                    break;
                case Difficulty.Hard:
                    retScoreList = new List<Score>(_hard);
                    break;
            }

            //Clear lists
            _easy.Clear();
            _medium.Clear();
            _hard.Clear();

            return retScoreList;


        }

    }
}
