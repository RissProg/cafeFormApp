namespace cafeFormApp
{
    public partial class Form1 : Form

    {
        int money = 250;

        int latte = 50;
        int mocha = 40;
        int americano = 60;

        int cookie = 35;
        int sandwich = 65;
        int cake = 50;

        int toplamTutar = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moneyLabel.Text = money.ToString() + "Tl";
        }

        private void cookiePictureBox_Click(object sender, EventArgs e)
        {
            toplamTutar += cookie;
            sepetListBox.Items.Add("Cookie");
        }

        private void lattePictureBox_Click(object sender, EventArgs e)
        {
            toplamTutar += latte;
            sepetListBox.Items.Add("Latte Coffe");
        }

        private void mochaPictureBox_Click(object sender, EventArgs e)
        {
            toplamTutar += mocha;
            sepetListBox.Items.Add("Mocha Coffe");
        }

        private void americanoPictureBox_Click(object sender, EventArgs e)
        {
            toplamTutar += americano;
            sepetListBox.Items.Add("Americano Coffe");
        }

        private void cakePictureBox_Click(object sender, EventArgs e)
        {
            toplamTutar += cake;
            sepetListBox.Items.Add("Cake");
        }

        private void sandwichPictureBox_Click(object sender, EventArgs e)
        {
            toplamTutar += sandwich;
            sepetListBox.Items.Add("Sandwich");
        }

        private void OdemeButton_Click(object sender, EventArgs e)
        {
            if (toplamTutar <= 250 && money>0)
            {
                money = money - toplamTutar;
                moneyLabel.Text = money.ToString() + "TL";

                MessageBox.Show("Alisveris Yaptiginiz Ýcin Tesekkur Ederiz ! ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (money <0)
            {
                MessageBox.Show("Bakiye Yetersiz ! ", "Bigilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Paraniz Yetmemektedir !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
