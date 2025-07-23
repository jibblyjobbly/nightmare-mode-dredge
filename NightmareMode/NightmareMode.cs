using UnityEngine;
using Winch.Core;

namespace NightmareMode
{
	public class NightmareMode : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(NightmareMode)} has loaded!");
		}
	}
}
