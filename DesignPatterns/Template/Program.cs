using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorthm scoringAlgorthm;
            Console.WriteLine("Men");
            scoringAlgorthm = new MensScoringAlgorithm();
            Console.WriteLine(scoringAlgorthm.GenerateScore(10,new TimeSpan(0,2,34)));

            Console.WriteLine("Women");
            scoringAlgorthm = new WomenScoringAlgorithm();
            Console.WriteLine(scoringAlgorthm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.WriteLine("Childs");
            scoringAlgorthm = new ChildrensScoringAlgorithm();
            Console.WriteLine(scoringAlgorthm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.ReadLine();

        }
    }

    abstract class ScoringAlgorthm
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverAllScore(score, reduction);
        }

        public abstract int CalculateOverAllScore(int score, int reduction);

        public abstract int CalculateReduction(TimeSpan time);

        public abstract int CalculateBaseScore(int hits);
    }
    class MensScoringAlgorithm : ScoringAlgorthm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverAllScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int) time.TotalSeconds / 5;
        }
    }

    class WomenScoringAlgorithm : ScoringAlgorthm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverAllScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }
    }

    class ChildrensScoringAlgorithm : ScoringAlgorthm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 80;
        }

        public override int CalculateOverAllScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }
    }
}
