using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleCodeFirst.Model
{
	[Table("MyAnnotateTable")]
	public class AnnotateMe
	{
		[Column("Joe")]
		public string CallMeJoe { get; set; }

		[MaxLength(5)]
		public string ShortString { get; set; }

		[Key]
		public int TheKey { get; set; }
	}
}