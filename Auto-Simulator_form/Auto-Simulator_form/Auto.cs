using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Auto_Simulator_form
{
    internal class Auto : IFahrezeug
    {
        string carName;
        int carHP;
        int speed;
        int status;
        int gear;

        public Auto(string CarName, int carHP)
        {
            this.carName = CarName;
            this.carHP = carHP;
        }

        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }

        public int CarHP
        {
            get { return carHP; }
            set { carHP = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Gear
        {
            get { return gear; }
            set { gear = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public void Accelerate()
        {
            if (status == 1)
            {
                if (speed < ((CarHP / 3) + 100))
                {
                    speed += (carHP / 200);
                }
            }
        }

        public void Brake()
        {
            if (status == 1)
            {
                if (speed > 0)
                {
                    speed -= (carHP / 100);
                    if (speed < 0)
                    {
                        speed = 0;
                    }
                }
            }
        }

        public void StartEngine()
        {
            status = 1;
            gear = 1;
        }


        public void StopEngine()
        {
            status = 0;
            gear = 0;
            speed = 0;
        }

        public void SetGear()
        {

            if (speed >= 0)
            {
                gear = 1;
            }

            if (speed > (((CarHP / 3) + 100) / 7 * 1))
            {
                gear = 2;
            }

            if (speed > (((CarHP / 3) + 100) / 7 * 2))
            {
                gear = 3;
            }

            if (speed > (((CarHP / 3) + 100) / 7 * 3))
            {
                gear = 4;
            }

            if (speed > (((CarHP / 3) + 100) / 7 * 4))
            {
                gear = 5;
            }

            if (speed > (((CarHP / 3) + 100) / 7 * 5))
            {
                gear = 6;
            }
        }

        public void Honk()
        {
            Console.WriteLine(System.IO.Path.GetFullPath("../../../honk.wav"));
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(System.IO.Path.GetFullPath("../../../honk.wav"));
            player.Play();
        }

        public void EngineSound()
        {
            Console.WriteLine(System.IO.Path.GetFullPath("../../../engine.wav"));
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(System.IO.Path.GetFullPath("../../../engine.wav"));
            player.Play();
        }

      
    }
}
