namespace LeetCode
{
    public class PlaceFlowers
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int flowerbedLength = flowerbed.Length;
            bool isLastFlowerFound = false;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    if (!isLastFlowerFound && n > 0 &&
                        (i + 1 > flowerbedLength - 1 || flowerbed[i + 1] == 0))
                    {
                        n--;//Place flower
                        isLastFlowerFound = true;
                    }
                    else
                        isLastFlowerFound = false;
                }
                else if (isLastFlowerFound)
                    return false;
                else
                    isLastFlowerFound = true;
            }

            return n == 0;
        }

        //public bool CanPlaceFlowers(int[] flowerbed, int n)
        //{
        //    int flowerbedLength = flowerbed.Length;
        //    bool isLastFlowerFound = false;

        //    for (int i = 0; i < flowerbed.Length; i++)
        //    {
        //        if (i == 0 && i + 1 < flowerbedLength - 1 &&
        //            flowerbed[i] == 0 && flowerbed[i + 1] == 1)
        //            continue;
        //        else if (flowerbed[i] == 0)
        //        {
        //            if (!isLastFlowerFound && n > 0)
        //            {
        //                n--;//Place flower
        //                isLastFlowerFound = true;
        //            }
        //            else
        //                isLastFlowerFound = false;
        //        }
        //        else if (isLastFlowerFound)
        //            return false;
        //        else
        //            isLastFlowerFound = true;
        //    }

        //    return n == 0;
        //}
    }
}
