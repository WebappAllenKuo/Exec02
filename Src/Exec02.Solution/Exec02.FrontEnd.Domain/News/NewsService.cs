using System.Collections.Generic;
using Exec02.FrontEnd.Domain.Interfaces;

namespace Exec02.FrontEnd.Domain.News
{
	public class NewsService
	{
		private readonly INewsRepository _newsRepository;

		public NewsService(INewsRepository newsRepository)
		{
			_newsRepository = newsRepository;
		}

		public IEnumerable<NewsEntity> GetHotNews(int rows)
		{
			return _newsRepository.GetHotNews(rows);
		}
	}
}