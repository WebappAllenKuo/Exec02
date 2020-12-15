using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Exec02.FrontEnd.Application.ViewModels
{
	public class HotNewsVM
	{
		public int Id { get;internal set; }
		
		public string Title { get; internal set; }

		[DisplayFormat(ApplyFormatInEditMode = false,DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
		public DateTime PublishTime { get; internal set; }
	}
}