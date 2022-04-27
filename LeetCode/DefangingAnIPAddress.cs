using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DefangingAnIPAddress
    {
        public string DefangIPaddr(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                return address;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                    sb.Append("[.]");
                else
                    sb.Append(address[i]);
            }

            return sb.ToString();
        }
    }
}
