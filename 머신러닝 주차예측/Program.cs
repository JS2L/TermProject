using System;
using 머신러닝_주차예측ML.Model;
namespace 머신러닝_주차예측
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput()
            {
                SystemCodeNumber = "BHMBCCMKT01",
                Capacity = 577,
                LastUpdated = "2016-10-05 12:29"
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine("예측점유율{0}:", result.Score);
        }
    }
}
