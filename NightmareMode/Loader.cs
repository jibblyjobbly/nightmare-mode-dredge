using UnityEngine;

namespace NightmareMode
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(NightmareMode));
			gameObject.AddComponent<NightmareMode>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}