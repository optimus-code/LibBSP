using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace LibBSP
{
	/// <summary>
	/// Replacement for FileInfo so we can support stream classes
	/// </summary>
	public class BSPFileInfo
	{
		public string Name
		{
			get;
			set;
		}

		public string FullName
		{
			get;
			set;
		}

		public string Directory
		{
			get;
			set;
		}

		public long Length
		{
			get;
			set;
		}
	}
}
