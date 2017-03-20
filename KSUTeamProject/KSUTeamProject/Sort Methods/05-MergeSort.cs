using System;

namespace Mergery
{
	/// <summary>
	/// Статический класс сортировки массива методом слияния.
	/// </summary>
	public static class MergeSort
	{
		/// <summary>
		/// Метод сортировки массива слиянием.
		/// </summary>
		/// <param name="inPutMas">Входной массив.</param>
		/// <returns>Отсортированный массив.</returns>
		static public int[] Sort(ref int[] inPutMas)
		{
			if (inPutMas.Length > 1)
			{
				int[] left = new int[inPutMas.Length / 2], right = new int[inPutMas.Length - left.Length]; //массивы для хранения левой и правой половин входного массива
				
				//заполнение массивов-половин элементами входного массива
				for (int i = 0; i < left.Length; i++)
					left[i] = inPutMas[i];				
				for (int i = 0; i < right.Length; i++)
					right[i] = inPutMas[left.Length + i];			
				
				if (left.Length > 1)
					left = Sort(ref left);
				if (right.Length > 1)
					right = Sort(ref right);
				
				inPutMas = Merge(left, right);
			}
			return inPutMas;
		}
		
		/// <summary>
		/// Метод сортировки слиянием.
		/// </summary>
		/// <param name="leftBorder">Массив левой половины входного массива.</param>
		/// <param name="rightBorder">Массив правой половины входного массива.</param>
		/// <returns>Отсортированный массив.</returns>
		static int[] Merge(int[] leftBorder, int[] rightBorder)
		{
			int[] buffer = new int[leftBorder.Length + rightBorder.Length];
			
			int countLeft = 0, countRight = 0; //счётчики элементов массивов левой и правой половин входного массива
			
			for (int i = 0; i < buffer.Length; i++)
				if (countRight >= rightBorder.Length)
				{
					buffer[i] = leftBorder[countLeft];
					countLeft++;
				}
				else
					if (countLeft < leftBorder.Length && leftBorder[countLeft] < rightBorder[countRight])
					{						
						buffer[i] = leftBorder[countLeft];
						countLeft++;
					}
					else
					{
						buffer[i] = rightBorder[countRight];
						countRight++;
					}
					
			return buffer;
		}
	}
}