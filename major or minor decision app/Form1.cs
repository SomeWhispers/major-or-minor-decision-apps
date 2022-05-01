namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sampleData = new MLModel1.ModelInput()
            {
                X = Convert.ToSingle(textBox1.Text),
                Y = Convert.ToSingle(textBox2.Text)
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);

            textBox3.Text += String.Format("{0:f} (Score 0:{1:f}, 1:{2:f})\r\n", result.Prediction, result.Score[0], result.Score[1]);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}