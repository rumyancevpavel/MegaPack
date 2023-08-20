using UnityEditor;
using UnityEngine;
using Xternity.Editor.Utils;

namespace Xternity.Editor.Menus
{
	public class ConfigureXternityMenu
	{
		[MenuItem("Xternity/SDK/Configure")]
		public static void ConfigureXternityMenuItem()
		{
			SdkConfiguration.Get();
		}
	}
}