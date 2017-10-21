using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCDS_RCON.Tests
{
	[TestCategory("SrcdsRcon")]
	[TestClass]
	public class SrcdsRconTests
	{
		/// <summary>
		/// Check that we can get the filename of the executable
		/// </summary>
		[TestMethod]
		public void GetAssemblyFileName_OK()
		{
			Assert.IsNotNull(SrcdsRcon.GetAssemblyFileName());
		}

		/// <summary>
		/// Check that the settings are defined and usable
		/// </summary>
		[TestMethod]
		public void GetSettings_OK()
		{
			Assert.IsNotNull(SrcdsRcon.Settings);
		}
	}
}
