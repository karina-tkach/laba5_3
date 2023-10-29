namespace laba5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(700, 400);
            this.MaximumSize = new Size(700, 400);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Square square = new Square(this.Width / 4, this.Height / 2, this.Width / 3);
            square.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(this.Width / 4, this.Height / 2, this.Width / 6);
            circle.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rhomb rhomb = new Rhomb(this.Width / 4, this.Height / 2, this.Width / 4, this.Width / 3);
            rhomb.MoveRight();
        }
    }
}