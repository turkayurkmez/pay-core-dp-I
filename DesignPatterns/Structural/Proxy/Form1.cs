namespace Proxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Math math = new Math();
            MathProxy mathProxy = new MathProxy(math);
            double mathResult = mathProxy.Add(3, 5);

        }
    }
}