using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Simulator_form
{
    public partial class Form1 : Form
    {
        Auto auto = null;
     //   Lastwagen lastwagen = null;

        public Form1()
        {
            InitializeComponent();
            cbx_Fahrzeug.DisplayMember = "CarName";
            lbl_status.Text = "ON";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_Fahrzeug.Items.Add(new Auto("VW Golf", 200));
            cbx_Fahrzeug.Items.Add(new Auto("BMW M4", 430));
            cbx_Fahrzeug.Items.Add(new Auto("Lamborghini Huracan", 640));
            cbx_Fahrzeug.Items.Add(new Lastwagen("Laster", 330));

        }

        private void cbx_Cars_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto = cbx_Fahrzeug.SelectedItem as Auto;
       //     lastwagen = cbx_Fahrzeug.SelectedItem as Lastwagen;
       //     lbl_PS.Text = lastwagen.TruckHP.ToString();
       //     cbx_Fahrzeug.Text = lastwagen.TruckName.ToString();

            lbl_PS.Text = auto.CarHP.ToString();
            cbx_Fahrzeug.Text = auto.CarName.ToString();
            if (auto.Status == 1)
            {
                lbl_status.Text = "OFF";
            }
            if (auto.Status == 0)
            {
                lbl_status.Text = "ON";            }

            lbl_ShowSpeed.Text = auto.Speed.ToString();
            lbl_ShowGear.Text = auto.Gear.ToString();
        }

        private void lbl_status_Click(object sender, EventArgs e)
        {
            if (this.auto != null)
            {
                if (lbl_status.Text == "ON")
                {
                    lbl_status.Text = "OFF";
                    auto.StartEngine();
                    lbl_ShowSpeed.Text = auto.Speed.ToString();
                    lbl_ShowGear.Text = auto.Gear.ToString();
                    auto.EngineSound();
                }
                else
                {
                    lbl_status.Text = "ON";
                    auto.StopEngine();
                    lbl_ShowSpeed.Text = auto.Speed.ToString();
                    lbl_ShowGear.Text = auto.Gear.ToString();
                }
            }
        }

        private void btn_Brake_Click(object sender, EventArgs e)
        {

        }

        /*private void btn_Gas_Hover(object sender, EventArgs e)
        {
            if (auto.Status == 1)
            {
                auto.Accelerate();
            }
        }*/

        private void btn_Gas_MouseHover_1(object sender, EventArgs e)
        {
            if (this.auto != null)
            {
                auto.Accelerate();
                if (auto.Status == 1)
                {
                    auto.SetGear();
                }
                lbl_ShowSpeed.Text = auto.Speed.ToString();
                btn_Gas.Visible = false;
                btn_Gas.Visible = true;
                lbl_ShowGear.Text = auto.Gear.ToString();
            }
        }

        private void btn_Brake_MouseHover(object sender, EventArgs e)
        {
            if (this.auto != null)
            {
                auto.Brake();
                if (auto.Status == 1)
                {
                    auto.SetGear();
                }
                lbl_ShowSpeed.Text = auto.Speed.ToString();
                btn_Brake.Visible = false;
                btn_Brake.Visible = true;
                lbl_ShowGear.Text = auto.Gear.ToString();
            }
        }

        private void btn_honk_Click(object sender, EventArgs e)
        {
            if (auto != null && auto.Status == 1)
            {
                auto.Honk();
            }
        }

    }
}
