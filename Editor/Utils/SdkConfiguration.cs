using Xternity.Runtime.Configuration;
using UnityEditor;
using UnityEngine;

namespace Xternity.Editor.Utils
{
	public class SdkConfiguration
	{
		private const string SdkConfigFilePath = "Assets/Resources/Xternity/SDK Config.asset";
		public static void Get()
		{
			var fileHandler = AssetDatabase.LoadAssetAtPath<XternityUnitySdkConfig>(SdkConfigFilePath);
			if (fileHandler == null)
			{
				fileHandler = ScriptableObject.CreateInstance<XternityUnitySdkConfig>();
				AssetDatabase.CreateAsset(fileHandler, SdkConfigFilePath);
			}
			
			Selection.activeObject = fileHandler;
		}
	}
}