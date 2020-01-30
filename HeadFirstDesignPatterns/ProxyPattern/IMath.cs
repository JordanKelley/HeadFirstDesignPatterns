using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.ProxyPattern
{
    /// <summary>
    /// The Subject interface
    /// </summary>
    public interface IMath
    {
        public double Add(double x, double y);
        public double Sub(double x, double y);
        public double Mul(double x, double y);
        public double Div(double x, double y);
    }
}
