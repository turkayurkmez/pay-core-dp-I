namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Composite<Category> categories = new Composite<Category>();
            var bilgisayar = categories.Add(new Category("Bilgisayar"));
            var laptop = bilgisayar.Add(new Category("Laptop"));
            var sesSistemi = categories.Add(new Category("Ses Sistemi"));
            var blueTooth = sesSistemi.Add(new Category("Bluetooth"));

            Composite<Category>.Show(1, categories, treeView2);

        }
    }
}