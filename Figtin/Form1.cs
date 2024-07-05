namespace Figtin
{
    public partial class Form1 : Form
    {
        private Random rand = new();
        private bool isClick = false;
        private int count = 0;
        PLAYER Pl = new(100, "Man", 10);
        BOT Bot = new("GAD");
        public Form1()
        {
            InitializeComponent();
            Label_HP_2.Text = "HP: " + Bot.HP.ToString();
            Label_HP.Text = "HP: " + Pl.HP.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Atak_Click(object sender, EventArgs e)
        {
            timer1.Start();
            isClick = true;
            Pl.Attack(Bot);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isClick)
            {
                count++;
                Label_HP_2.Text = "HP: " + Bot.HP.ToString();
                Label_HP.Text = "HP: " + Pl.HP.ToString();
                isClick = false;
            }
            if (count == 2)
            {
                Bot.Attack(Pl);
                Label_HP.Text = "HP: " + Pl.HP.ToString();
                timer1.Stop();
                count = 0;
            }
        }

        private void button_Inv_Click_1(object sender, EventArgs e)
        {
            Pl.Heal(20);
            timer1.Start();
            isClick = true;
        }
    }
}
