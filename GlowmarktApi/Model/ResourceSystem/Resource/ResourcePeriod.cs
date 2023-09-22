using System;

namespace Glowmarkt.Model.ResourceSystem.Resource
{
	public class ResourcePeriod
	{
		private const int
			_minute = 60,
			_hour = _minute * 60,
			_day = _hour * 24,
			_week = _day * 7;

		public static readonly ResourcePeriod
			PT1M = new ResourcePeriod("PT1M", _minute, _day * 2, "1-minute level"),
			PT30M = new ResourcePeriod("PT30M", _minute * 30, _day * 10, "30-minute level"),
			PT1H = new ResourcePeriod("PT1H", _hour, _day * 31, "1-hour level"),
			P1D = new ResourcePeriod("P1D", _day, _day * 31, "1-day level"),
			P1W = new ResourcePeriod("P1W", _week, _week * 6, "1-week level"),
			P1M = new ResourcePeriod("P1M", _day * 30, _day * 366, "1-month level"),
			P1Y = new ResourcePeriod("P1Y", _week * 52, _day * 366, "1-year level");

		public string Parameter { get; }

		public string Description { get; }

		public int WindowSize { get; }

		public int WindowLimit { get; }

		private ResourcePeriod(string parameter, int windowSize, int windowLimit, string description)
		{
			Parameter = parameter;
			WindowSize = windowSize;
			WindowLimit = windowLimit;
			Description = description;
		}

		public static implicit operator ResourcePeriod(string value)
		{
			return value switch
			{
				"PT1M" => PT1M,
				"PT30M" => PT30M,
				"PT1H" => PT1H,
				"P1D" => P1D,
				"P1W" => P1W,
				"P1M" => P1M,
				"P1Y" => P1Y,
				_ => throw new InvalidOperationException()
			};
		}
	}
}
