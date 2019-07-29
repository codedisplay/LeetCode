using System.Text;

namespace LeetCode
{
    public class Alphabet_Board_Path
    {
        public string AlphabetBoardPath(string target)
        {
            StringBuilder sb = new StringBuilder();
            int iRow = 0, iCol = 0, iRowTarget, iColTarget;

            for (int i = 0; i < target.Length; i++)
            {
                iRowTarget = (target[i] - 'a') / 5;
                iColTarget = (target[i] - 'a') % 5;

                while (true)
                {
                    if (iRow < iRowTarget)
                    {
                        while (iRow == 4 && iCol > 0)
                        {
                            iCol--;
                            sb.Append('L');
                        }
                        iRow++;
                        sb.Append('D');
                    }
                    else if (iRow > iRowTarget)
                    {
                        iRow--;
                        sb.Append('U');
                    }
                    else if (iCol < iColTarget)
                    {
                        if (iRow == 5)
                        {
                            iRow--;
                            sb.Append('U');
                        }
                        iCol++;
                        sb.Append('R');
                    }
                    else if (iCol > iColTarget)
                    {
                        iCol--;
                        sb.Append('L');
                    }
                    else
                    {
                        sb.Append('!');
                        break;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
