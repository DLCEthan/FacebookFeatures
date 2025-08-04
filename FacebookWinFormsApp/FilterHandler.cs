using System;

namespace BasicFacebookFeatures
{
	public class FilterHandler<T> : IFilterHandler<T>
	{
		public Predicate<T> Filter { get; set; }
		public IFilterHandler<T> NextHandler { get; set; }
		public Func<bool, bool, bool> LogicalOperator { get; set; } = (b1, b2) => b1 && b2;

		public bool Handle(T i_ItemToFilter)
		{
			bool isFiltered = Filter.Invoke(i_ItemToFilter);

			return NextHandler != null
				? LogicalOperator.Invoke(isFiltered, NextHandler.Handle(i_ItemToFilter)) : isFiltered;
		}
	}
}