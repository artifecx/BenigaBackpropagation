using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenigaBackpropagation
{
    internal class TrainingData
    {
        public static List<Tuple<double[], double[]>> GetTrainingDataA()
        {
            List<Tuple<double[], double[]>> trainingData = new List<Tuple<double[], double[]>>
            {
                Tuple.Create(new double[] { 0.0, 0.0 }, new double[] { 0.0 }), // 0 0
                Tuple.Create(new double[] { 0.0, 1.0 }, new double[] { 1.0 }), // 0 1
                Tuple.Create(new double[] { 1.0, 0.0 }, new double[] { 1.0 }), // 1 0
                Tuple.Create(new double[] { 1.0, 1.0 }, new double[] { 1.0 })  // 1 1
            };

            return trainingData;
        }

        public static List<Tuple<double[], double[]>> GetTrainingDataB()
        {
            List<Tuple<double[], double[]>> trainingData = new List<Tuple<double[], double[]>>
            {
                Tuple.Create(new double[] { 0.0, 0.0, 0.0, 0.0 }, new double[] { 0.0 }), // 0 0 0 0
                Tuple.Create(new double[] { 0.0, 0.0, 0.0, 1.0 }, new double[] { 1.0 }), // 0 0 0 1
                Tuple.Create(new double[] { 0.0, 0.0, 1.0, 0.0 }, new double[] { 1.0 }), // 0 0 1 0
                Tuple.Create(new double[] { 0.0, 0.0, 1.0, 1.0 }, new double[] { 1.0 }), // 0 0 1 1
                Tuple.Create(new double[] { 0.0, 1.0, 0.0, 0.0 }, new double[] { 1.0 }), // 0 1 0 0
                Tuple.Create(new double[] { 0.0, 1.0, 0.0, 1.0 }, new double[] { 1.0 }), // 0 1 0 1
                Tuple.Create(new double[] { 0.0, 1.0, 1.0, 0.0 }, new double[] { 1.0 }), // 0 1 1 0
                Tuple.Create(new double[] { 0.0, 1.0, 1.0, 1.0 }, new double[] { 1.0 }), // 0 1 1 1
                Tuple.Create(new double[] { 1.0, 0.0, 0.0, 0.0 }, new double[] { 1.0 }), // 1 0 0 0
                Tuple.Create(new double[] { 1.0, 0.0, 0.0, 1.0 }, new double[] { 1.0 }), // 1 0 0 1
                Tuple.Create(new double[] { 1.0, 0.0, 1.0, 0.0 }, new double[] { 1.0 }), // 1 0 1 0
                Tuple.Create(new double[] { 1.0, 0.0, 1.0, 1.0 }, new double[] { 1.0 }), // 1 0 1 1
                Tuple.Create(new double[] { 1.0, 1.0, 0.0, 0.0 }, new double[] { 1.0 }), // 1 1 0 0
                Tuple.Create(new double[] { 1.0, 1.0, 0.0, 1.0 }, new double[] { 1.0 }), // 1 1 0 1
                Tuple.Create(new double[] { 1.0, 1.0, 1.0, 0.0 }, new double[] { 1.0 }), // 1 1 1 0
                Tuple.Create(new double[] { 1.0, 1.0, 1.0, 1.0 }, new double[] { 1.0 })  // 1 1 1 1
            };

            return trainingData;
        }

        public static List<Tuple<double[], double[]>> GetTrainingDataC()
        {
            List<Tuple<double[], double[]>> trainingData = new List<Tuple<double[], double[]>>
            {
                Tuple.Create(new double[] { 0.0, 0.0 }, new double[] { 0.0 }), // 0 0
                Tuple.Create(new double[] { 0.0, 1.0 }, new double[] { 0.0 }), // 0 1
                Tuple.Create(new double[] { 1.0, 0.0 }, new double[] { 0.0 }), // 1 0
                Tuple.Create(new double[] { 1.0, 1.0 }, new double[] { 1.0 })  // 1 1
            };

            return trainingData;
        }

        public static List<Tuple<double[], double[]>> GetTrainingDataD()
        {
            List<Tuple<double[], double[]>> trainingData = new List<Tuple<double[], double[]>>
            {
                Tuple.Create(new double[] { 0.0, 0.0, 0.0, 0.0 }, new double[] { 0.0 }), // 0 0 0 0
                Tuple.Create(new double[] { 0.0, 0.0, 0.0, 1.0 }, new double[] { 0.0 }), // 0 0 0 1
                Tuple.Create(new double[] { 0.0, 0.0, 1.0, 0.0 }, new double[] { 0.0 }), // 0 0 1 0
                Tuple.Create(new double[] { 0.0, 0.0, 1.0, 1.0 }, new double[] { 0.0 }), // 0 0 1 1
                Tuple.Create(new double[] { 0.0, 1.0, 0.0, 0.0 }, new double[] { 0.0 }), // 0 1 0 0
                Tuple.Create(new double[] { 0.0, 1.0, 0.0, 1.0 }, new double[] { 0.0 }), // 0 1 0 1
                Tuple.Create(new double[] { 0.0, 1.0, 1.0, 0.0 }, new double[] { 0.0 }), // 0 1 1 0
                Tuple.Create(new double[] { 0.0, 1.0, 1.0, 1.0 }, new double[] { 0.0 }), // 0 1 1 1
                Tuple.Create(new double[] { 1.0, 0.0, 0.0, 0.0 }, new double[] { 0.0 }), // 1 0 0 0
                Tuple.Create(new double[] { 1.0, 0.0, 0.0, 1.0 }, new double[] { 0.0 }), // 1 0 0 1
                Tuple.Create(new double[] { 1.0, 0.0, 1.0, 0.0 }, new double[] { 0.0 }), // 1 0 1 0
                Tuple.Create(new double[] { 1.0, 0.0, 1.0, 1.0 }, new double[] { 0.0 }), // 1 0 1 1
                Tuple.Create(new double[] { 1.0, 1.0, 0.0, 0.0 }, new double[] { 0.0 }), // 1 1 0 0
                Tuple.Create(new double[] { 1.0, 1.0, 0.0, 1.0 }, new double[] { 0.0 }), // 1 1 0 1
                Tuple.Create(new double[] { 1.0, 1.0, 1.0, 0.0 }, new double[] { 0.0 }), // 1 1 1 0
                Tuple.Create(new double[] { 1.0, 1.0, 1.0, 1.0 }, new double[] { 1.0 })  // 1 1 1 1
            };

            return trainingData;
        }
    }
}
