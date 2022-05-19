using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjectBank.Aplication.Util
{
	public static class AssemblyUtil
	{

		public static IEnumerable<Assembly> GetCurrentAssemblies()
		{
			return new Assembly[]
			{
				Assembly.Load("ProjectBank.Api"),
				Assembly.Load("ProjectBank.Aplication"),
				Assembly.Load("ProjectBank.Domain")
			};
		}
	}
}
