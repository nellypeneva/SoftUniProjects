using System;
namespace _08_PersonalException
{
    class NegativeException : Exception
    {
        public NegativeException() : base("My first exception is awesome!!!")
        {
        }
    }
}
