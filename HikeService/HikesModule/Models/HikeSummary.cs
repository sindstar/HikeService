﻿using HikeService.WeatherModule.Models;

namespace HikeService.HikesModule.Models
{
	public class HikeSummary
	{
		public HikeDetails HikeDetails { get; set; }
        public WeatherDetails[] WeatherDetails { get; set; } 
	}
}