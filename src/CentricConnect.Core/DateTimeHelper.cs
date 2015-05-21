using System;

namespace Griz.Core
{
	public static class DateTimeHelper
	{
		public static DateTime? OverridenDateTime { get; set; }

		public static DateTime Now
		{
			get
			{
				return OverridenDateTime == null ? DateTime.Now : OverridenDateTime.Value;
			}
		}

    public static DateTime UtcNow
    {
      get
      {
        return OverridenDateTime == null ? DateTime.UtcNow : OverridenDateTime.Value.ToUniversalTime();
      }
    }
	}
}