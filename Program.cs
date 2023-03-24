using System;
using System.Speech.Recognition;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SetInputToDefaultAudioDevice();

            recognizer.SpeechRecognized += (sender, eventArgs) =>
            {
                Console.WriteLine("You said: " + eventArgs.Result.Text);
            };

            recognizer.RecognizeAsync(RecognizeMode.Multiple);

            Console.WriteLine("Listening... Press Enter to stop.");
            Console.ReadLine();

            recognizer.Dispose();
        }
    }
}
