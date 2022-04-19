using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBall.Mod.Common
{
	public class DataArgs
	{
		private Dictionary<string, object> data = new Dictionary<string, object>();
		public void Set(string key, object value)
		{ 
			data.Add(key, value);
		}

		public object Get(string key)
		{
			object value;
			data.TryGetValue(key, out value);
			return value;

		}
	}
}
