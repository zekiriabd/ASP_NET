using ConsumerApp.ConvertService;
using ConsumerApp.FibonacciService;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsumerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private async Task<string> LoadDataAsync()
        {

            await Task.Delay(1);
            Application.DoEvents();

            FibonacciController fibonacciService = new FibonacciController();
            int? result = await Task.FromResult(fibonacciService.Fibonacci(int.Parse(textBox1.Text)));
            return (result == null ? "" : result.ToString());
        }

       

        private async void button1_Click(object sender, EventArgs e)
        {
            var progressForm = new Form2();
            var progressFormTask = progressForm.ShowDialogAsync();
            var data = await LoadDataAsync();
            progressForm.Close();
            await progressFormTask;
            MessageBox.Show(data.ToString());
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = await LoadJesonDataAsync();
        }
        private async Task<string> LoadJesonDataAsync()
        {
            XmalObject xx = new XmalObject() { xmlData = textBox2.Text };
            Application.DoEvents();
            ConvertController convertService = new ConvertController();

            return await Task.FromResult(convertService.XmlToJson(xx));
        }
    }
}
