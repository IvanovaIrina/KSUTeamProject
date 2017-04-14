using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSUTeamProject {
	class _1_FastSort {
        public static void Sort(int[] input, int l, int r)
        {
            int temp;
            int x = input[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных 
            int i = l;
            int j = r;

            while (i <= j)
            {
                while (input[i] < x) i++;
                while (input[j] > x) j--;
                if (i <= j)
                {
                    temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                    j--;

                }
            }
            if (i < r)
                Sort(input, i, r);

            if (l < j)
                Sort(input, l, j);
        }
    }
}
