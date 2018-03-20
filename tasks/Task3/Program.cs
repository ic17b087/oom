using System;

namespace Task2
{

    public enum Power
    {
        ON,
        OFF
    };

    interface Device
    {
        void togglePower();
        Power getStatus();
    }

    public class Camera : Device
    {

        private Power pow = Power.OFF;

        private int ISO;
        private double aperture;
        private int sSpeed;

        private string date;
        private string time;

        public Camera(int ISO, double aperture, int sSpeed, string date, string time)
        {
            this.ISO = ISO;
            this.aperture = aperture;
            this.sSpeed = sSpeed;
            this.date = date;
            this.time = time;
        }

        public int getISO()
        {
            if(pow == Power.ON) {
                return ISO;
            }
            else
            {
                return 0;
            }
            
        }

        public double getAperture()
        {
            if (pow == Power.ON)
            {
                return aperture;
            }
            else
            {
                return 0;
            }
        }

        public int getSSpeed()
        {
            if (pow == Power.ON)
            {
                return sSpeed;
            }
            else
            {
                return 0;
            }
        }

            public int setISO(int newISO)
        {
            if (pow == Power.ON)
            {
                ISO = newISO;
                return ISO;
            }
            else
            {
                return 0;
            }
        }

        public double setAperture(double newAperture)
        {
            if (pow == Power.ON)
            {
                aperture = newAperture;
                return aperture;
            }
            else
            {
                return 0;
            }
        }

        public int setSSpeed(int newSSpeed)
        {
            if (pow == Power.ON)
            {
                sSpeed = newSSpeed;
                return sSpeed;
            }
            else
            {
                return 0;
            }
            
        }

        public void togglePower()
        {
            if (pow == Power.ON)
            {
                pow = Power.OFF;
            }
            else
            {
                pow = Power.ON;
            }
        }

        public Power getStatus()
        {
            return pow;
        }
    }

    class Computer : Device {

        private Power pow = Power.OFF;

        public void togglePower()
        {
            if (pow == Power.ON)
            {
                pow = Power.OFF;
            }
            else
            {
                pow = Power.ON;
            }
        }

        public Power getStatus()
        {
            return pow;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Camera cam1 = new Camera(100, 2.8, 80, "01/03/2011", "12:35");

            Console.WriteLine(cam1.getISO());
            Console.WriteLine(cam1.getAperture());
            Console.WriteLine(cam1.getSSpeed());

            cam1.togglePower();

            Computer com1 = new Computer();

            Device[] devArr = { cam1, com1 };

            Console.WriteLine(cam1.getISO());
            Console.WriteLine(cam1.getAperture());
            Console.WriteLine(cam1.getSSpeed());

            Console.WriteLine(cam1.setISO(200));
            Console.WriteLine(cam1.setAperture(4));
            Console.WriteLine(cam1.setSSpeed(60));

            cam1.togglePower();

            foreach(Device d in devArr) 
            {
                Console.WriteLine("OFF=" + d.getStatus());
                d.togglePower();
                Console.WriteLine("ON=" + d.getStatus());
            }

        }
    }
}
