using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongPressedName
    {
        public bool IsLongPressedName(string name, string typed)
        {
            if (string.IsNullOrEmpty(name))
                return true;
            if (string.IsNullOrEmpty(typed))
                return false;

            int iName = 0, iTyped = 0;

            while (iName < name.Length || iTyped < typed.Length)
            {
                if (iName == name.Length || iTyped == typed.Length)
                    return false;
                if (name[iName] != typed[iTyped])
                    return false;

                int nameCounter = 0;
                do
                {
                    nameCounter++;
                    iName++;
                } while (iName < name.Length  && name[iName - 1] == name[iName]);

                int typeCounter = 0;
                do
                {
                    typeCounter++;
                    iTyped++;
                } while (iTyped < typed.Length  && typed[iTyped - 1] == typed[iTyped]);

                if (nameCounter > typeCounter)
                    return false;
            }

            return true;
        }
    }
}
