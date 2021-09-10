using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElKhattabiNaima_Prova7_MorraCinese.WFA
{
    public partial class MorraCinese : Form
    {
        int user, pc, count=0, countUser=0,countPc=0;
        public MorraCinese()
        {
            InitializeComponent();
        }

        private void btnSasso_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::ElKhattabiNaima_Prova7_MorraCinese.WFA.Properties.Resources.sasso;
            user = 1;
            txtValue.Clear();
        }

        private void btnForbici_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::ElKhattabiNaima_Prova7_MorraCinese.WFA.Properties.Resources.forbice;
            user = 2;
            txtValue.Clear();
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::ElKhattabiNaima_Prova7_MorraCinese.WFA.Properties.Resources.carta;
            user = 3;
            txtValue.Clear();
        }


        private void btnConferma_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int choice = random.Next(1, 4);
            switch (choice)
            {
                case 1:
                    pictureBox2.Image = global::ElKhattabiNaima_Prova7_MorraCinese.WFA.Properties.Resources.sasso;
                    pc = 1;
                    txtValue.Clear();
                    break;
                case 2:
                    pictureBox2.Image = global::ElKhattabiNaima_Prova7_MorraCinese.WFA.Properties.Resources.forbice;
                    pc = 2;
                    txtValue.Clear();
                    break;
                case 3:
                    pictureBox2.Image = global::ElKhattabiNaima_Prova7_MorraCinese.WFA.Properties.Resources.carta;
                    pc = 3;
                    txtValue.Clear();
                    break;
            }

            if (user == pc)
            {
                txtValue.Text = "parità";
            }
            else if (user == 1 && pc == 2 || user == 1 && pc == 3 || user == 3 && pc == 1 || user == 2 && pc ==3)
            {
                countUser += 1;
                textBoxUser.Text = $"{countUser}";
                if ((countUser + countPc == 3) && countUser > countPc)
                {
                    txtValue.Text = $"Hai vinto {countUser} a {countPc} :) !";
                    count = 0;
                    countPc = 0;
                    countUser = 0;
                    textBoxComputer.Clear();
                    textBoxUser.Clear();
                    return;
                }
                else if ((countUser + countPc == 3) && countUser < countPc)
                {
                    txtValue.Text = $"Hai perso {countUser} a {countPc} :( !";
                    count = 0;
                    countPc = 0;
                    countUser = 0;
                    textBoxComputer.Clear();
                    textBoxUser.Clear();
                    return;
                }
                count++;
            }
            else
            {
                countPc += 1;
                textBoxComputer.Text = $"{countPc}";
                if ((countUser + countPc == 3) && countUser > countPc)
                {
                    txtValue.Text = $"Hai vinto {countUser} a {countPc} :) !";
                    count = 0;
                    countPc = 0;
                    countUser = 0;
                    textBoxComputer.Clear();
                    textBoxUser.Clear();
                    return;
                }
                else if ((countUser + countPc == 3) && countUser < countPc)
                {
                    txtValue.Text = $"Hai perso {countUser} a {countPc} :( !";
                    count = 0;
                    countPc = 0;
                    countUser = 0;
                    textBoxComputer.Clear();
                    textBoxUser.Clear();
                    return;
                }
                count++;
            }
            //pictureBox1.Image = global::ElKhattabiNaima_Prova7_MorraCinese.WFA.Properties.Resources.detective_1424831_1280;
            //pictureBox2.Image = global::ElKhattabiNaima_Prova7_MorraCinese.WFA.Properties.Resources.detective_1424831_1280;
        }
    }
}
