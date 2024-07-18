using System;
using System.Collections.Generic;
using System.Text;

namespace OBEB_Metodu
{
    class Matematik
    {
        public static int OBEB(int s1, int s2)
        {
            int s = 1;
            int bolen = 2;
            while (s1 != 1 && s2 != 2)
            {
                for (int i = 2; i < (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bolen == 0 || s2 % bolen == 0)
                    {
                        if (s1 % bolen == 0 && s2 % bolen == 0)
                            s *= bolen;
                        if (s1 % bolen == 0)
                            s1 /= bolen;
                        if (s2 % bolen == 0)
                            s2 /= bolen;

                    }
                    else
                        bolen++;
                }
            }
            return s;
        }
    }
}
