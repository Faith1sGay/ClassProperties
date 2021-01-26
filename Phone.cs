using System;
namespace Phone
{
    public class PhoneTypes
    {
        string _manufacturer;
        string _color;
        string _OS;
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string OS
        {
            get { return _OS; }
            set { _OS = value; }
        }
    }
}