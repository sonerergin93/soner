using System;
using Microsoft.CognitiveServices.Speech;

namespace SpeechToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = SpeechConfig.FromSubscription("YOUR_SUBSCRIPTION_KEY", "YOUR_REGION");
            using (var recognizer = new SpeechRecognizer(config))
            {
                Console.WriteLine("Say something...");
                var result = recognizer.RecognizeOnceAsync().Result;
                Console.WriteLine($"Text: {result.Text}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
