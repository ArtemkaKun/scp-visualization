using SCPVisualization.MVVM;
using SCPVisualization.ScreensManagement;
using UnityEngine;

namespace SCPVisualization.Screens
{
	public class MainMenuModel : Model
	{
		[field: SerializeField]
		private ScreenNamePicker SCPLibraryScreenPicker { get; set; }
		[field: SerializeField]
		private ScreenManager ScreenManager { get; set; }
		
		public void OpenSCPLibrary ()
		{
			ScreenManager.ShowScreen(SCPLibraryScreenPicker.ScreenName);
		}

		public void ExitFromApp ()
		{
			if (Application.isEditor == false)
			{
				Application.Quit();
			}
		}
	}
}