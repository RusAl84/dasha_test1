using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dasha_test1
{
    internal class Message
    {
        public Message()
        {
            UserName = "Default";
            MessageText = "Hello";
            TimeStamp = "12:30";
            nums2 = new int[6];
        }

        public string UserName { get; set; }
        public string MessageText { get; set; }
        public string TimeStamp { get; set; }
        public int Age { get; set; }

        public int[] nums2  { get; set; }
        public override string ToString()
        {
            string output = String.Format("{0} <{2}>: {1}", UserName, MessageText, TimeStamp);
            return output;
        }
    }
}
