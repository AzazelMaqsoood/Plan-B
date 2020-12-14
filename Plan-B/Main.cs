﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Plan_B
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        //string AdminIs;

        public Main()
        {
            
            InitializeComponent();
            //Кастоматизация дизайна при помощи MaterialSkin.dll
            MaterialSkin.MaterialSkinManager SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sotr sotr = new Sotr();
            sotr.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Zadachi zadachi = new Zadachi();
            zadachi.Show();
            this.Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Program.IsAdmin != "saphir99")
            {
                BtnZadachi.Visible = false;
                BtnMonitoring.Visible = false;
            }
            else
            {
                BtnSotr.Visible = false;
            }
            chart1.Series["Имя"].Points.AddXY("Никита", 5);
            chart1.Series["Имя"].Points.AddXY("Денис", 2);
            chart1.Series["Имя"].Points.AddXY("Сергей", 3);
            chart1.Series["Имя"].Points.AddXY("Вадим", 12);

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            this.Hide();
            about.Show();
        }

        private void BtnSotr_Click(object sender, EventArgs e)
        {
            Sotr sotr = new Sotr();
            this.Hide();
            sotr.Show();
        }

        private void BtnZadachi_Click(object sender, EventArgs e)
        {
            Zadachi zadachi = new Zadachi();
            this.Hide();
            zadachi.Show();
        }

        private void BtnMonitoring_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }
    }
}
