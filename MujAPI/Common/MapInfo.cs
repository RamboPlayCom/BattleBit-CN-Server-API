﻿using BattleBitAPI.Common;

namespace MujAPI.Common
{
	public class MapInfo
	{
		public Maps Map { get; set; }
		public MapDayNight DayNight { get; set; }

		public MapInfo(Maps map, MapDayNight dayNight)
		{
			Map = map;
			DayNight = dayNight;
		}

		public MapInfo()
		{
		}

		public override string ToString()
		{
			return this.Map.ToString() + " : " + this.DayNight.ToString();
		}
	}
}