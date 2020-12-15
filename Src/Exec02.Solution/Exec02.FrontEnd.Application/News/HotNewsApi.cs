using System;
using System.Collections.Generic;
using Exec02.FrontEnd.Application.ViewModels;

namespace Exec02.FrontEnd.Application.News
{
	public class HotNewsApi
	{
		/// <summary>
		/// 傳回最新的N則News
		/// </summary>
		/// <param name="maxRows"></param>
		/// <returns></returns>
		public IEnumerable<HotNewsVM> GetHotNews(int maxRows)
		{
			throw new NotImplementedException();
		}
	}
}