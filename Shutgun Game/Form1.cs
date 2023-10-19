using System.Media;

namespace Shutgun_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool fortsatt;
        Random random = new Random();
        string playerChoice;
        int playerAmmo;
        int computerAmmo;

        public void PlayGame()
        {
            string computerChoice = ComputerChoice();
            while (fortsatt)
            {
                switch (playerChoice)
                {
                    case "ladda":
                        if (computerChoice == "ladda")
                        {
                            playerAmmo++;
                            computerAmmo++;
                            pAmmo.Text = playerAmmo.ToString();
                            cAmmo.Text = computerAmmo.ToString();
                            fortsatt = false;
                        }
                        else if (computerChoice == "skjuta" && computerAmmo < 3)
                        {
                            RestartGame();
                            MessageBox.Show("Du förlorade");
                            RestartGame();
                            fortsatt = false;
                        }
                        else if (computerChoice == "skjuta" && computerAmmo >= 3)
                        {
                            MessageBox.Show("Du förlorade");
                            RestartGame();
                            fortsatt = false;
                        }
                        else if (computerChoice == "blocka")
                        {
                            playerAmmo++;
                            pAmmo.Text = playerAmmo.ToString();
                            cAmmo.Text = computerAmmo.ToString();
                            fortsatt = false;
                        }
                        break;

                    case "skjuta":
                        if (playerAmmo >= 3)
                        {
                            MessageBox.Show("Du vann");
                            RestartGame();
                            fortsatt = false;
                        }
                        else if (computerChoice == "ladda")
                        {
                            fortsatt = false;
                            MessageBox.Show("Du vann!");
                            RestartGame();
                        }
                        else if (computerChoice == "skjuta" && computerAmmo < 3)
                        {
                            playerAmmo--;
                            computerAmmo--;
                            pAmmo.Text = playerAmmo.ToString();
                            cAmmo.Text = computerAmmo.ToString();
                            fortsatt = false;
                        }
                        else if (computerChoice == "skjuta" && computerAmmo >= 3)
                        {
                            MessageBox.Show("Du förlorade");
                            RestartGame();
                            fortsatt = false;
                        }
                        else if (computerChoice == "blocka")
                        {
                            playerAmmo--;
                            pAmmo.Text = playerAmmo.ToString();
                            cAmmo.Text = computerAmmo.ToString();
                            fortsatt = false;
                        }
                        break;

                    case "blocka":
                        if (computerChoice == "ladda")
                        {
                            computerAmmo++;
                            pAmmo.Text = playerAmmo.ToString();
                            cAmmo.Text = computerAmmo.ToString();
                            fortsatt = false;
                        }
                        else if (computerChoice == "skjuta" && computerAmmo < 3)
                        {
                            computerAmmo--;
                            pAmmo.Text = playerAmmo.ToString();
                            cAmmo.Text = computerAmmo.ToString();
                            fortsatt = false;
                        }
                        else if (computerChoice == "skjuta" && computerAmmo >= 3)
                        {
                            MessageBox.Show("Du förlorade");
                            RestartGame();
                            fortsatt = false;

                        }
                        else if (computerChoice == "blocka")
                        {
                            pAmmo.Text = playerAmmo.ToString();
                            cAmmo.Text = computerAmmo.ToString();
                            fortsatt = false;
                        }
                        break;
                }
                if (playerAmmo >= 3)
                {
                    skjuttaButton.Text = "Shotgun";
                }
            }
        }

        public string ComputerChoice()
        {
            string ladda = "ladda";
            string blocka = "blocka";
            string skjuta = "skjuta";
            

            int randomnumber = random.Next(1, 4);
            int randomnumber2 = random.Next(1, 3);

            if (randomnumber == 1)
            {
                return ladda;
            }
            else if (randomnumber == 2)
            {
                return blocka;
            }
            else if (randomnumber == 3 && computerAmmo < 1)
            {
                if (randomnumber2 == 1)
                {
                    return ladda;
                }
                else if (randomnumber2 == 2)
                {
                    return blocka;
                }
            }
            else if (randomnumber == 3 && computerAmmo > 0)
            {
                return skjuta;
            }

            return "0";
        }
        public void RestartGame()
        {
            playerAmmo = 0;
            computerAmmo = 0;
            pAmmo.Text = playerAmmo.ToString();
            cAmmo.Text = computerAmmo.ToString();
        }

        private void laddaButton_Click(object sender, EventArgs e)
        {
            playerChoice = "ladda";
            fortsatt = true;
            PlayGame();
        }

        private void skjuttaButton_Click(object sender, EventArgs e)
        {

            if (playerAmmo > 0)
            {
                playerChoice = "skjuta";
                fortsatt = true;
                PlayGame();
            }
        }

        private void blockaButton_Click(object sender, EventArgs e)
        {
            playerChoice = "blocka";
            fortsatt = true;
            PlayGame();
        }
    }
}