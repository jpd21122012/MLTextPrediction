using System;
using TextPredictionML.Model;

namespace TextPrediction.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sentiment Prediction");
            Console.WriteLine("Insert your text to evaluate...");
            // Add input data
            var input = new ModelInput();
            input.SentimentText = Console.ReadLine();

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine("The result was a "+ ( !result.Prediction ? "Good" : "Bad")+ " Sentiment");
            Console.ReadLine();
        }
    }
}
