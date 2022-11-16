using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR10_1
{
    internal class Angle
    {
        int grad;
        int min;
        int sec;
        public bool isCorrect = true;

        public int Grad
        {
            get
            {
                return grad;
            }
            set
            {

                if (value < 0)
                { isCorrect = false; }
                else
                { grad = value % 360; }

            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                { isCorrect = false; }
                else
                {
                    Grad += value / 60;
                    min = value % 60;
                }
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                { isCorrect = false; }
                else
                {
                    Min += value / 60;
                    sec = value % 60;
                }
            }
        }
        public Angle(int grad, int min, int sec)
        {
            this.Grad = grad;
            this.Min = min;
            this.Sec = sec;
        }
        
        public double ToRadians()
        {
            return (grad + ( min + sec/60)/60)*Math.PI/180 ;
        }
    }
    
}
