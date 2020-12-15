using Exec02.FrontEnd.Application.ViewModels;
using Exec02.FrontEnd.Domain.News;

namespace Exec02.FrontEnd.Application.News
{
	internal static class NewsEntityAssembler
	{
		public static HotNewsVM ToHotNewsVM(this NewsEntity entity)
		{
			return new HotNewsVM
			{
				Id=entity.Id,
				Title = entity.Title
			};
		}
	}
}