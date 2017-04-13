using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSUTeamProject {
    class _8_InsertSort {
		public static void Sort(ref int[] mas)  
		{
			int key,nomsim;
			for (int i = 1; i < mas.Length; i++)  //i=1???
			{
				key = mas[i];          
				nomsim = i-1;        
				while (nomsim > -1 && mas[nomsim] > key)      
				{ 
					mas[nomsim + 1] = mas[nomsim];       
					nomsim--;   
				}
				mas[nomsim + 1] = key;
			}
		}
	}
}
