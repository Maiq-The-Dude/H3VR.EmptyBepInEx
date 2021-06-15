using BepInEx;

namespace InfiniteCasings
{
	[BepInPlugin("maiq.Plugin", "Plugin", "0.1.0")]
	[BepInProcess("h3vr.exe")]
	public class InfiniteCasings : BaseUnityPlugin
	{
		public InfiniteCasings()
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