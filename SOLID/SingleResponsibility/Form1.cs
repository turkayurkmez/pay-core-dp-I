namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);

            var affectedRows = new ProductService().AddProduct(name, price);

            var result = affectedRows > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(result);

        }
    }
}