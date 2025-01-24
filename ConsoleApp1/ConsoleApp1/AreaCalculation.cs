using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AreaCalculation
    {
        double areaSize;

        public double rectangularCalculation(double oneSide,double twoSide)
        
        {

            areaSize = oneSide * twoSide;

            return areaSize;

        }
        public double circleCalculation(double radius) 
        {
            areaSize = radius *radius* Math.PI;
            return areaSize;
        }
     }



}


