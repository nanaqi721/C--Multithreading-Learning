namespace TaskOffload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => ShowMessage("First message", 3000));
            thread.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => ShowMessage("Second message", 5000));
            thread.Start();
        }

        private void ShowMessage(string message,int delay) 
        {
            Thread.Sleep(delay);
            IbIMessage.BeginInvoke(new Action(() =>
            {
                IbIMessage.Text = message;
            }));
        }


    }
}