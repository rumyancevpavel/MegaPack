using UnityEngine;

namespace Xternity.Runtime.Configuration
{
	public class XternityUnitySdkConfig : ScriptableObject
	{
		#region Editor
		
		[SerializeField]
		private string _serverUrl;

		#endregion

		#region Properties

		public string ServerUrl => _serverUrl;

		#endregion
	}
}