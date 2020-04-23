using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media.Animation;

namespace DesktopClock
{
	public class CurrentTimeStringAnimation : StringAnimationBase
	{
		protected override Freezable CreateInstanceCore()
		{
			return new CurrentTimeStringAnimation();
		}

		protected override string GetCurrentValueCore(string defaultOriginValue, string defaultDestinationValue, AnimationClock animationClock)
		{
			return DateTime.Now.ToLongTimeString();
		}
	}
}
