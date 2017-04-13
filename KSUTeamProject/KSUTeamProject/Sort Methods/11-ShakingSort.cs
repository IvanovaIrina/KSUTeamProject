using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSUTeamProject {
    class _11_ShakingSort {
        public void Sort (ref int[] mas) {
            int low = 0;
            int high = mas.Length - 1;

            int h = 0;
            bool flag = true;
            while (low < high && flag) {
                flag = false;
                for (int o = low; o < high; o++) { // проход массива от начала к концу, перемещение большего значения
                    if (mas[o] > mas[o + 1]) {
                        h = mas[o];
                        mas[o] = mas[o + 1];
                        mas[o + 1] = h;
                        flag = true;
                    }
                }
                high--; // сокращение сортируемого диапазона от конца

                for (int i = high; i > low; i--) { // проход массива от конца к началу, перемещение меньшего значения
                    if (mas[i - 1] > mas[i]) {
                        h = mas[i];
                        mas[i] = mas[i - 1];
                        mas[i - 1] = h;
                        flag = true;
                    }
                }
                low++; // сокращение сортируемого диапазона от начала
            }
        }
    }
}
