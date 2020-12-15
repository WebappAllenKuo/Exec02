using System;
using Microsoft.SqlServer.Server;

namespace Exec02.FrontEnd.Domain.News
{
	public class NewsEntity
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime PublishTime { get; set; }
		public DateTime CreatedTime { get; set; }
		public DateTime LastModifiedTime { get; set; }
	}
}