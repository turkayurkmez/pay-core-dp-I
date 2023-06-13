namespace Flyweight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createPlanets(splitContainer1.Panel1.CreateGraphics(), numericUpDown1.Value);
        }

        private void createPlanets(Graphics graphics, decimal value)
        {
            var colorList = new List<Color> { Color.Blue, Color.White, Color.Yellow };
            Random random = new Random();

            for (int i = 0; i < value; i++)
            {
                Planet planet = PlanetFlyweight.CreatePlanet(colorList[random.Next(colorList.Count)]);
                planet.X = random.Next(0, splitContainer1.Panel1.Width);
                planet.Y = random.Next(0, splitContainer1.Panel1.Height);

                planet.Radius = random.Next(2, 100);
                planet.Draw(graphics);

            }
        }
    }
}