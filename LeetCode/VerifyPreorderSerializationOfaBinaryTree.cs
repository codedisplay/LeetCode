namespace LeetCode
{
    public class VerifyPreorderSerializationOfaBinaryTree
    {
        public bool IsValidSerialization(string preorder)
        {
            string[] values = preorder.Split(',');
            int requiredLeafNodes = 1;

            foreach (string val in values)
            {
                if (requiredLeafNodes == 0)
                    return false;

                if (val != "#")
                    requiredLeafNodes += 2;

                requiredLeafNodes--;
            }

            return requiredLeafNodes == 0;
        }

        //public bool IsValidSerialization(string preorder)
        //{
        //    string[] values = preorder.Split(',');
        //    int requiredLeftNodes = 1;
        //    int requiredRightNodes = 1;

        //    if (values.Length > 1 && values[0] == "#")
        //        return false;

        //    int currentHashCount = 0;

        //    foreach (string val in values)
        //    {
        //        if (val != "#")
        //        {
        //            if (currentHashCount == 2)
        //                requiredRightNodes--;
        //            else
        //                requiredLeftNodes--;

        //            requiredLeftNodes++;
        //            requiredRightNodes++;
        //            currentHashCount = 0;
        //        }
        //        else
        //        {
        //            if (currentHashCount == 1)
        //                requiredLeftNodes--;
        //            else if (currentHashCount > 1)
        //                requiredRightNodes--;

        //            currentHashCount++;
        //        }
        //    }

        //    return requiredLeftNodes == 0 && requiredRightNodes == 0;
        //}
    }
}
