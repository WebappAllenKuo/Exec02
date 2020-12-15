using System;
using System.ComponentModel;

namespace Exec02.FrontEnd.Application.ViewModels
{
	public class HotNewsVM
	{
		public int Id { get; set; }
		
		public string Title { get; set; }

		public DateTime PublishTime { get; set; }
	}
}