using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    public interface ITelephone
    {
        public void powerOn();
        public void dial(int phoneNumber);
        public void answer();
        public Boolean callPhone(int phoneNumber);
        public Boolean isRinging();
    }
}
