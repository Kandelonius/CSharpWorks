using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    class DeskPhone : ITelephone
    {
        public int myNumber
        {
            get { return myNumber; }
            set
            {
                if (value > 0 && value < 100000)
                    myNumber = value;
            }
        }
        private Boolean isRinging;

        public DeskPhone()
        {

        }

        public DeskPhone(int number)
        {
            myNumber = number;
        }

        void ITelephone.powerOn()
        {
            Console.WriteLine("Greetings from the manufacturer");
        }

        public void answer()
        {
            if(isRinging)
            {
                Console.WriteLine("Call coming in");
                isRinging = false;
            }
        }

        public bool callPhone(int phoneNumber)
        {
            if(phoneNumber == myNumber)
            {
                isRinging = true;
                Console.WriteLine("Please pick up");
            } 
            else
            {
                isRinging = false;
            }
            return isRinging;
        }

        public void dial(int phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber}!");
        }

        bool ITelephone.isRinging()
        {
            return isRinging;
        }
    }
}
