using System;

namespace BasicFacebookFeatures
{
	public interface IFilterHandler<T>
	{
		Predicate<T> Filter { get; set; }
		IFilterHandler<T> NextHandler { get; set; }
		bool Handle(T i_ItemToFilter);
	}
}