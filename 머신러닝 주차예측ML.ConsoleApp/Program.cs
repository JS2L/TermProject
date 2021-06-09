// This file was auto-generated by ML.NET Model Builder. 

using System;
using 머신러닝_주차예측ML.Model;

namespace 머신러닝_주차예측ML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                SystemCodeNumber = @"BHMBCCMKT01",
                Capacity = 577F,
                LastUpdated = @"2016-10-04 07:59:42",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Occupancy with predicted Occupancy from sample data...\n\n");
            Console.WriteLine($"SystemCodeNumber: {sampleData.SystemCodeNumber}");
            Console.WriteLine($"Capacity: {sampleData.Capacity}");
            Console.WriteLine($"LastUpdated: {sampleData.LastUpdated}");
            Console.WriteLine($"\n\nPredicted Occupancy: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
