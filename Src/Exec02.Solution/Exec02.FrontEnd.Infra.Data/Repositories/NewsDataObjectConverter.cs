using Exec02.FrontEnd.Domain.News;
using Exec02.FrontEnd.Infra.Data.EFModels;

namespace Exec02.FrontEnd.Infra.Data.Repositories
{
	internal static class NewsDataObjectConverter
	{
		public static NewsEntity ToEntity(this News efModel)
		{
			return new NewsEntity
			{
				Id = efModel.Id,
				Title = efModel.Title,
				Content = efModel.Content,
				PublishTime = efModel.PublishTime
			};
		}
	}
}