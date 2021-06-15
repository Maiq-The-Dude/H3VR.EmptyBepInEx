using BepInEx;

namespace H3VRMod
{
	[BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
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