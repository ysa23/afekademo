using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SywApplicationWireframe.Domain.Configuration
{
	public class MongoConfiguration
	{
		public string GetUrl()
		{
			return ConfigurationManager.AppSettings["mongo:url"];
		}

		public string GetDatabaseName()
		{
			return ConfigurationManager.AppSettings["mongo:database-name"];
		}
	}
}
