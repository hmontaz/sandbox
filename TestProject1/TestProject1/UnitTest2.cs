using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
	public partial class UnitTest2
	{
		[Fact]
		public void WriteNewFile()
		{
			var path = Path.GetFullPath("..\\..\\..\\..\\snapshots\\snapshot 12\\");
			var dataFile = new DataFile(Path.Combine(path, "VENOM_ud_data.dat"));
			var fraction = 1f - 1e-28f;

			//dataFile.UpgradeMedalShop();
			//dataFile.ResetAllDates();
			dataFile.GetExperience(float.MaxValue * fraction);
			dataFile.GetRich("amount", float.MaxValue * fraction);
			dataFile.GetRich("total_collected", 0);
			//dataFile.UpgradeMines("capacity", float.MaxValue / 10);

			//-----------------
			var output_path = Path.Combine(path, "modified");
			Directory.CreateDirectory(output_path);
			dataFile.Save(Path.Combine(output_path, "VENOM_ud_data.dat"));
		}
	}
}
