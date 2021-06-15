using BepInEx;

namespace H3VRMod
{
	[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
	[BepInProcess("h3vr.exe")]
	public class Plugin : BaseUnityPlugin
	{
		public Plugin()
		{
			Hook();
		}

		private void OnDestroy()
		{
			Unhook();
		}

		private void Hook()
		{

		}

		private void Unhook()
		{

		}
	}
}