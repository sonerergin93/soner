using System.Speech.Recognition;

namespace KONUSMA
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine recognizer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dinle_Click(object sender, EventArgs e)
        {
            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("tr-TR"));

            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SetInputToDefaultAudioDevice();

            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec_SpeechRecognized);

            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            textBox1.Text = e.Result.Text;
        }
    }
}
