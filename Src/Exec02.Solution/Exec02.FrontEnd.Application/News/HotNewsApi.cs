using System;
using System.Collections.Generic;
using System.Linq;
using Exec02.FrontEnd.Application.ViewModels;
using Exec02.FrontEnd.Domain.News;

namespace Exec02.FrontEnd.Application.News
{
	public class HotNewsApi
	{
		private readonly NewsService _newsSvc;

		public HotNewsApi(NewsService newsSvc)
		{
			_newsSvc = newsSvc;
		}

		/// <summary>
		/// 傳回最新的N則News
		/// </summary>
		/// <param name="maxRows"></param>
		/// <returns></returns>
		public IEnumerable<HotNewsVM> GetHotNews(int maxRows)
		{
			IEnumerable<NewsEntity> data = _newsSvc.GetHotNews(maxRows);

			if (data == null) return Enumerable.Empty<HotNewsVM>();

			return data.Select(entity => entity.ToHotNewsVM());
		}
	}
}