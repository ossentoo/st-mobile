﻿using UIKit;

namespace SpaceLinx.Training.iOS
{
	//Create statice device helper to capture the current device. This will be used to detect screen orientation
	public static class DeviceHelper
	{
		public static UIDevice iOSDevice {
			get;
			set;
		}
	}
}