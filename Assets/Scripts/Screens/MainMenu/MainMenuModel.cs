using SCPVisualization.MVVM;
using SCPVisualization.ScreensManagement;
using UnityEngine;

namespace SCPVisualization.UI.Screens
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
			Debug.Log("Exit");
		}
	}
}