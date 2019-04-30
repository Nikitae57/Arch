using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Algorithm
{
	// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
	// ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
	public class AlgorithmService : IAlgorithmService
	{
		public int BinarySearch(int[] mas, int id)
		{
			int left = 0, right = mas.Length - 1;
			while (left <= right)
			{
				int mid = (left + right) / 2;
				if (id == mas[mid])
				{
					return mid;
				}
				if (id < mas[mid])
				{
					right = mid - 1;
				}
				else
				{
					left = mid + 1;
				}
			}
			return -1;
	
		}

		public int[] Sort(int[] mas)
		{
			quicksort(mas, 0, mas.Length - 1);
			return mas;
		}

		int partition(int[] array, int start, int end)
		{
			int temp;
			int marker = start;
			for (int i = start; i <= end; i++)
			{
				if (array[i] < array[end]) 
				{
					temp = array[marker]; 
					array[marker] = array[i];
					array[i] = temp;
					marker += 1;
				}
			}
			
			temp = array[marker];
			array[marker] = array[end];
			array[end] = temp;
			return marker;
		}

		void quicksort(int[] array, int start, int end)
		{
			if (start >= end)
			{
				return;
			}
			int pivot = partition(array, start, end);
			quicksort(array, start, pivot - 1);
			quicksort(array, pivot + 1, end);
		}
	}
}
