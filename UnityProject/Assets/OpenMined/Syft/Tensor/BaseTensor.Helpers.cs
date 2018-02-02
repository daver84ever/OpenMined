using System;
using System.Collections.Generic;

namespace OpenMined.Syft.Tensor
{
	public partial class BaseTensor 
	{
		public enum SortOrder { Ascending, Descending };

		protected void Sort<T>(T[] elements, IComparer<T> comparer) 
		{/*
			IComparer comparer;
			switch (order)
			{

				case: SortOrder.Descending;
					
					break;
				case: SortOrder.Ascending;
				default:

					break;
			}
			*/
			Array.Sort(elements, comparer);
		}



		private class SortAscendingHelper : IComparer<float>
		{
			public int Compare(float x, float y)
			{
				if (x > y)
				{
					return 1;
				} 

				if (y > x)
				{
					return -1;
				}

				return 0;
			}
		}
}

