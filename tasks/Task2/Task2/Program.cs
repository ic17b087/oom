using System;

namespace Task2
{

    public class Camera
    {
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
            return ISO;
        }

        public double getAperture()
        {
            return aperture;
        }

        public int getSSpeed()
        {
            return sSpeed;
        }

        public int setISO(int newISO)
        {
            ISO = newISO;
            return ISO;
        }

        public double setAperture(double newAperture)
        {
            aperture = newAperture;
            return aperture;
        }

        public int setSSpeed(int newSSpeed)
        {
            sSpeed = newSSpeed;
            return sSpeed;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Camera c1 = new Camera(100, 2.8, 80, "01/03/2011", "12:35");

            Console.WriteLine(c1.getISO());
            Console.WriteLine(c1.getAperture());
            Console.WriteLine(c1.getSSpeed());

            Console.WriteLine(c1.setISO(200));
            Console.WriteLine(c1.setAperture(3.6));
            Console.WriteLine(c1.setSSpeed(60));
        }
    }
}
