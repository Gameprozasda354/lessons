using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Core.Models
{
	public class Country : BaseEntity
	{
        public string Name { get; set; }
		public string ShortName { get; set; }
		public List<City> Cities { get; set; }
		public User User { get; set; }
	}
}
