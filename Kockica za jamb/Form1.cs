namespace Kockica_za_jamb
{
    public partial class Form1 : Form
    {
        private int brojKlikova = 0;
        private int aktuelnaKockica = 1;
        private int brojOdabranihKockica = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("1.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (brojKlikova == 0)
            {
                timer1.Enabled = true;
            }
            else
            {
                brojOdabranihKockica++;
                if (brojOdabranihKockica == 1)
                {
                    pictureBox2.Image = new Bitmap(aktuelnaKockica + ".png");
                }
                else if (brojOdabranihKockica == 2)
                {
                    pictureBox3.Image = new Bitmap(aktuelnaKockica + ".png");
                }
                else if (brojOdabranihKockica == 3)
                {
                    pictureBox4.Image = new Bitmap(aktuelnaKockica + ".png");
                }
                else if (brojOdabranihKockica == 4)
                {
                    pictureBox5.Image = new Bitmap(aktuelnaKockica + ".png");
                }
                else if (brojOdabranihKockica == 5)
                {
                    pictureBox6.Image = new Bitmap(aktuelnaKockica + ".png");
                }
                else if (brojOdabranihKockica == 6)
                {
                    pictureBox7.Image = new Bitmap(aktuelnaKockica + ".png");
                    timer1.Enabled = false;
                    //sa ovim gasimo tajmer posto smo bacili sest kockica
                }
            }
            brojKlikova++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aktuelnaKockica++;
            if (aktuelnaKockica == 7) aktuelnaKockica = 1;
            pictureBox1.Image = new Bitmap(aktuelnaKockica + ".png");
        }
    }
}