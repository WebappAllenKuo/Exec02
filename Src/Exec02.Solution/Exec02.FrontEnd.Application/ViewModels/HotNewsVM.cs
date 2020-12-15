using System;
using System.ComponentModel;

namespace Exec02.FrontEnd.Application.ViewModels
{
	public class HotNewsVM
	{
		public int Id { get;internal set; }
		
		public string Title { get; internal set; }

		public DateTime PublishTime { get; internal set; }
	}
}