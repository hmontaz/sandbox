using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace TestProject1.UnitTests
{
	public class FindTests
	{
		[Fact]
		public void FindForward_Test()
		{
			var dataFile = new DataFile(new byte[] { 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7, 0x8, 0x9 });

			dataFile.FindForward(0, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.FirstByte).Should().Be(1);
			dataFile.FindForward(1, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.FirstByte).Should().Be(1);
			dataFile.FindForward(2, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.FirstByte).Should().Be(-1);

			dataFile.FindForward(0, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.NextByte).Should().Be(4);
			dataFile.FindForward(1, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.NextByte).Should().Be(4);
			dataFile.FindForward(2, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.NextByte).Should().Be(-1);
		}

		[Fact]
		public void FindBackward_Test()
		{
			var dataFile = new DataFile(new byte[] { 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7, 0x8, 0x9 });

			dataFile.FindBackward(9, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.FirstByte).Should().Be(1);
			dataFile.FindBackward(3, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.FirstByte).Should().Be(1);
			dataFile.FindBackward(2, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.FirstByte).Should().Be(-1);

			dataFile.FindBackward(9, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.NextByte).Should().Be(4);
			dataFile.FindBackward(3, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.NextByte).Should().Be(4);
			dataFile.FindBackward(2, new byte[] { 0x1, 0x2, 0x3 }, SearchByteResult.NextByte).Should().Be(-1);
		}
	}
}
