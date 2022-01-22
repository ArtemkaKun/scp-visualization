using SCPVisualization.MVVM;
using SCPVisualization.ScreensManagement;
using UnityEngine;

namespace SCPVisualization.UI.Screens
{
	public class SCPLibraryModel : Model
	{
		[field: SerializeField]
		private ScreenNamePicker MenuScreenPicker { get; set; }
		[field: SerializeField]
		private ScreenManager ScreenManager { get; set; }
		
		public void ReturnToMenu ()
		{
			ScreenManager.ShowScreen(MenuScreenPicker.ScreenName);
		}
	}
}