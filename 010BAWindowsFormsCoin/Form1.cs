using _010BAWindowsFormsCoin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010BAWindowsFormsCoin
{
    public partial class Form1Coin : Form
    {
        CoinService coinService = new CoinService();
        public Form1Coin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lPara.Text = "";
            lSonuc.Text = "";
            lbSonuc.Text = "";
        }

        private void bParaAt_Click(object sender, EventArgs e)
        {
            ParaAtClick();
        }

        private void ParaAtClick()
        {
            Coin coin = coinService.ParaAt();
            byte paraYuzu = (byte)coin.Yuzu;

            string path = Application.StartupPath;
            path = path.Replace("bin\\Debug", "Para");
            string fileName = paraYuzu + ".png";
            pbPara.Image = Image.FromFile(path + "\\" + fileName);

            if (paraYuzu == 0)
            {
                lSonuc.Text = "Yazı";
                lbSonuc.Items.Add(lSonuc.Text);
                lPara.Text = "Yazı";
            }
            else
            {
                lSonuc.Text = "Tura";
                lbSonuc.Items.Add(lSonuc.Text);
                lPara.Text = "Tura";
            }
        }
    }
}
