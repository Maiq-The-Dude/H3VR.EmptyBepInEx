using System;
using BepInEx;

namespace H3VRMod
{
	[BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
	[BepInProcess("h3vr.exe")]
	public class Plugin : BaseUnityPlugin
	{
		internal Hooks Hooks;
	
		public Plugin()
		{
			Hooks = new Hooks();
			Hooks.Hook();
		}

		private void Awake()
		{
			
		}

		private void Update()
		{
			
		}

		private void OnDestroy()
		{
			Hooks.Unhook();
		}
	}
}