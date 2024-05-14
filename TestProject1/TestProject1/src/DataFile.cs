﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
	public class DataFile
	{
		readonly byte[] _bytes;

		public DataFile(string sourcePath)
		{
			this._bytes = File.ReadAllBytes(sourcePath);
		}

		internal DataFile(byte[] bytes)
		{
			this._bytes = bytes;
		}

		public void UpgradeMedalShop()
		{
			var list = new[] {
				"Medal_Shop_Bronze_Catching_Speed",//	1/4
				"Medal_Shop_Bronze_Capacity",
				"Medal_Shop_Bronze_Health",
				"Medal_Shop_Bronze_Regen",
				"Medal_Shop_Silver_Catching_Speed",//	1/8
				"Medal_Shop_Silver_Capacity",
				"Medal_Shop_Silver_Health",
				"Medal_Shop_Silver_Regen",
				"Medal_Shop_Silver_Bronze_Mining_Rate",
				"Medal_Shop_Silver_Silver_Mining_Rate",
				"Medal_Shop_Silver_Gold_Mining_Rate",
				"Medal_Shop_Silver_Heat_Resist",
				"Medal_Shop_Gold_Catching_Speed" ,//	1/11
				"Medal_Shop_Gold_Capacity",
				"Medal_Shop_Gold_Health",
				"Medal_Shop_Gold_Regen",
				"edal_Shop_Gold_Bronze_Mining_Rate",
				"Medal_Shop_Gold_Silver_Mining_Rate",
				"Medal_Shop_Gold_Gold_Mining_Rate",
				"Medal_Shop_Gold_Heat_Resist",
				"Medal_Shop_Gold_Double_Resources",
				"Medal_Shop_Gold_Double_Exp",
				"Medal_Shop_Gold_Catching_Speed_Percent"};

			foreach (var item in list)
			{
				var index = Find(0, item);
				index = Find(index, "lvl", SearchingMethod.NextByte);
				Write(_bytes, ref index, new byte[] { 100 });
			}

		}

		public void GetExperience(float amount)
		{
			var list = new[] { "level_index>exp" };

			foreach (var item in list)
			{
				var path = item.Split(">").ToArray();
				WriteMultiPath(path, amount);
			}
		}
		public void GetRich(string key, float value)
		{
			var list = new[] {
				"Event_BookDay",
				"Event_BunnyCarrot",
				"Event_BunnyEgg",
				"Event_ClownDay",
				"Event_DemonDay",
				"Event_DinoDay",
				"Event_DragonInvasion",
				"Event_Drill",
				"Event_EasterDay",
				"Event_GenieDay",
				"Event_GoblinDay",
				"Event_GreekDay",
				"Event_HalloweenCandy",
				"Event_HalloweenPumpkin",
				"Event_Hoverboard",
				"Event_InvasionOfTheRings",
				"Event_JellyfishInvasion",
				"Event_KillerBeesInvasion",
				"Event_LamaDay",
				"Event_MagicianPotion",
				"Event_MagicianWand",
				"Event_MantaInvasion",
				"Event_MayaDay",
				"Event_MilitaryInvasion",
				"Event_NewYear",//pomegrante
				"Event_PatrickClover",
				"Event_PatrickGold",
				"Event_PonySparkDay",
				"Event_Robot",
				"Event_SakuraDay",
				"Event_ScarabDay",
				"Event_SpaceCrystal",
				"Event_SpaceLaser",
				"Event_SpaceWars_Gems",
				"Event_SpaceWars_Lightsaber",
				"Event_StPatrickDay",//lucky clover
				"Event_SuperDay",
				"Event_SurferDay",
				"Event_ThiefInvasion",
				"Event_TimeTravelers",
				"Event_ToolBox",
				"Event_TriguysInvasion",
				"Event_UFOInvasion",
				"Event_UnicornInvasion",
				"Event_VD2Arrow",
				"Event_VD2Heart",
				"Event_ValentinesDay",//heart
				"Event_VampireBat",
				"Event_VampireCandle",
				"Event_VikingDay",
				"Event_XmasCandyCane",
				"Event_XmasSantaHat",
				"Quest_1",
				"Quest_2",
				"Quest_3",
				"Quest_4",
				"Quest_5",
				"Quest_6",
				"Quest_7",
				"Quest_8",
				"Quest_9",
				"Quest_10",
				"Quest_11",
				"Quest_Rocket_1_1",
				"Quest_Rocket_1_5",
				"Quest_Rocket_2_1",
				"Quest_Rocket_2_10",
				"Quest_Rocket_3_1",
				"Quest_Rocket_3_10",
				"Quest_Rocket_4_1",
				"Quest_Rocket_4_10",
				"Winter_Zone",
				"SpecialFish1",
				"SpecialFish2",
				"SpecialFish3",
				"SpecialFish4",
				"SpecialFish5",
				"SpecialFish6",
				"SpecialFish7",
				"KeyMoney",
				"KeyCaviar",
				"KeySpecialFish",
				"Metall1",
				"Metall2",
				"Metall3",
				"BoneMinion",
				"BoneBoss",
				"TestCaviar>Money",
				"TestCaviar>Caviar",
				"MiniCaviar",//Broken Caviar
				"HardCurrency", //Gems
				"gps>SnowFlake", //Frozen Meat	
				"gps>OctopusBossKey",
				"gps>BrushWood",
				"TestMoney",
				"TestCaviar",
				"GoldenKey",
				"Quest_1_1",
				"Quest_1_2",
				"Quest_1_3",
				"Quest_1_4",
				"Quest_Winter_1",
				"Quest_Winter_2",
				"Quest_Winter_3",
				"Quest_Winter_4",
				"Quest_Winter_5",
				"Quest_Winter_6",
				"Quest_Winter_7",
				"WinterGem_1",
				"WinterGem_2",
				"WinterGem_3",
				"gps>NanoFiber",
				"gps>Gears",
				"gps>Wire",
				"gps>Battery",
				"gps>Servos",
				"gps>Acid",
				"gps>Money",
				"gps>Caviar",
				"Event_SpaceWars_Lightsaber",
				"Event_SpaceWars_Gems",
				"Event_SpaceLaser",
				"Event_SpaceCrystal",
			};
			foreach (var item in list)
			{
				var path = item.Split(">").Append(key).ToArray();
				WriteMultiPath(path, value);
			}
		}

		void WriteMultiPath(string[] path, float value)
		{
			var bytes = BitConverter.GetBytes(value).Reverse().ToArray();
			var index = FindMultiPath(0, path);
			if (_bytes[index] == 0xca)
			{
				//¦amountÊ
				index++;
				//Write(source, ref index, new byte[] { 0xca });
				Write(_bytes, ref index, bytes);
				//Write(source, ref index, new byte[] { 0xaf });
				return;
			}
			if (_bytes[index] == 0xb4)
			{
				//¦amount´3.40282346638529E+38
				index++;
				Write(_bytes, ref index, new byte[] { (byte)'2' });
				return;
			}
			throw new Exception($"Unhandled Byte 0x{_bytes[index].ToString("x")}");
		}

		int FindMultiPath(byte[] source, int startIndex, string[] keys)
		{
			var found = false;
			var index = startIndex;
			foreach (var key in keys)
			{
				index = Find(source, index, key, SearchingMethod.NextByte);
				found = true;
			}
			if (!found) return -1;
			return index;
		}

		int Find(byte[] source, int startIndex, string s, SearchingMethod method = SearchingMethod.FirstByte)
		{
			var bytes = Encoding.ASCII.GetBytes(s);
			return Find(source, startIndex, bytes, method);
		}
		int Find(byte[] source, int startIndex, byte[] bytes, SearchingMethod method)
		{
			int maxFirstCharSlot = source.Length - bytes.Length + 1;
			for (int i = startIndex; i < maxFirstCharSlot; i++)
			{
				if (source[i] != bytes[0]) // compare only first byte
					continue;

				// found a match on first byte, now try to match rest of the pattern
				for (int j = bytes.Length - 1; j >= 1; j--)
				{
					if (source[i + j] != bytes[j]) break;
					if (j == 1)
						return i + (method == SearchingMethod.NextByte ? bytes.Length : 0);
				}
			}
			return -1;
		}
		void Write(byte[] dest, ref int index, byte[] bytes)
		{
			foreach (var b in bytes)
			{
				dest[index++] = b;
			}
		}

		public void Save(string path)
		{
			var folderPath = string.Join('\\', path.Split('\\').Reverse().Skip(1).Reverse());
			Directory.CreateDirectory(folderPath);
			File.WriteAllBytes(path, this._bytes);
		}

		public void ResetAllDates()
		{
			//Overwrite All Dates
			var index = 0;
			var n = 0;
			while (true)
			{
				index = Find(_bytes, index, new byte[] { 0xd7, 0xff }, SearchingMethod.FirstByte);
				if (index < 0) break;
				n++;

				index += 3;
				//Write(_bytes, ref index, new byte[] { /*0xd7, 0xff, 0x8d,*/ 0xcd, 0x45, 0x20, 0x64, 0xc8/*, 0x66, 0x2f*/ });//worked
				Write(_bytes, ref index, new byte[] { /*0xd7, 0xff, 0x8d,*/ 0x00, 0x00, 0x00, 0x00, 0x00/*, 0x66, 0x2f*/ });//worked better
			}
		}
	}
}
