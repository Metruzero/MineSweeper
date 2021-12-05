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


        private BinaryReader br;
        private BinaryWriter bw;
        private string fileName;
        private List<Score> easy;
        private List<Score> medium;
        private List<Score> hard;
        private const int MaxScores = 5;

        public ScoreController()
        {
            //File name
            fileName = @"..\scores.bin";

            //Check if file exists
            if (!File.Exists(fileName))
            {
                bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));
                bw.Close();
            }

            //Declare lists
            easy = new List<Score>();
            medium = new List<Score>();
            hard = new List<Score>();


        }

        public void WriteScores()
        {

            bw = new BinaryWriter(new FileStream(fileName, FileMode.Open));

            //Write Easy
            for (int i = 0; i < easy.Count; i++)
            {
                bw.Write(easy[i].name);
                bw.Write((int)easy[i].diff);
                bw.Write(easy[i].time);
            }

            //Clear easy
            easy.Clear();

            //Write Medium
            for (int i = 0; i < medium.Count; i++)
            {
                bw.Write(medium[i].name);
                bw.Write((int)medium[i].diff);
                bw.Write(medium[i].time);
            }

            //Clear medium
            medium.Clear();

            //Write hard
            for (int i = 0; i < hard.Count; i++)
            {
                bw.Write(hard[i].name);
                bw.Write((int)hard[i].diff);
                bw.Write(hard[i].time);
            }

            //Clear medium
            hard.Clear();

            bw.Close();

        }

        private void LoadScores()
        {
            br = new BinaryReader(new FileStream(fileName, FileMode.Open));

            while (true)
            {
                try
                {
                    string s = br.ReadString();
                    int diff = br.ReadInt32();
                    int score = br.ReadInt32();

                    Score tempScore = new Score(s, (Difficulty)diff, score);

                    switch (tempScore.diff)
                    {
                        case Difficulty.Easy:
                            easy.Add(tempScore);
                            break;
                        case Difficulty.Medium:
                            medium.Add(tempScore);
                            break;
                        case Difficulty.Hard:
                            hard.Add(tempScore);
                            break;
                    }
                }
                catch (IOException e)
                {
                    break;
                }
            }

            br.Close();
        }

        public void AddScore(string name, Difficulty diff, int score)
        {
            //Load Score call
            LoadScores();

            Score tempScore = new Score(name, diff, score);

            switch (tempScore.diff)
            {
                case Difficulty.Easy:
                    easy.Add(tempScore);
                    break;
                case Difficulty.Medium:
                    medium.Add(tempScore);
                    break;
                case Difficulty.Hard:
                    hard.Add(tempScore);
                    break;
            }

            //
            //
            //                      Easy Score Code
            //
            //Sort list by time
            easy = easy.OrderBy(s => s.time).ToList<Score>();

            //Check is list needs trimming
            if (easy.Count > MaxScores)
            {
                trimScores(easy);
            }

            //
            //
            //                      Medium Score Code
            //
            //Sort list by time
            medium = medium.OrderBy(s => s.time).ToList<Score>();

            //Check is list needs trimming
            if (medium.Count > MaxScores)
            {
                trimScores(medium);
            }

            //
            //
            //                      Hard Score Code
            //
            //Sort list by time
            hard = hard.OrderBy(s => s.time).ToList<Score>();

            //Check is list needs trimming
            if (hard.Count > MaxScores)
            {
                trimScores(hard);
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
                    if (easy.Count < MaxScores)
                    {
                        highScore = true;
                    }
                    else
                    {
                        //If the score is less than the highest value, then it is a new high score
                        if (easy[4].time > time)
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
                    if (medium.Count < MaxScores)
                    {
                        highScore = true;
                    }
                    else
                    {
                        //If the score is less than the highest value, then it is a new high score
                        if (medium[4].time > time)
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
                    if (hard.Count < MaxScores)
                    {
                        highScore = true;
                    }
                    else
                    {
                        //If the score is less than the highest value, then it is a new high score
                        if (hard[4].time > time)
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
            easy.Clear();
            medium.Clear();
            hard.Clear();

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
                    retScoreList = new List<Score>(easy);
                    break;
                case Difficulty.Medium:
                    retScoreList = new List<Score>(medium);
                    break;
                case Difficulty.Hard:
                    retScoreList = new List<Score>(hard);
                    break;
            }

            //Clear lists
            easy.Clear();
            medium.Clear();
            hard.Clear();

            return retScoreList;


        }

    }
}
