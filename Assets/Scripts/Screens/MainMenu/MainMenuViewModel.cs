using SCPVisualization.MVVM;
using UnityEngine.UIElements;

namespace SCPVisualization.UI.Screens
{
	public class MainMenuViewModel : ViewModel<MainMenuModel>
	{
		private void Awake ()
		{
			View.rootVisualElement.Q<Button>("SCPLibrary").clicked += OpenSCPLibrary;
			View.rootVisualElement.Q<Button>("Exit").clicked += ExitFromApp;
		}

		private void OpenSCPLibrary ()
		{
			Model.OpenSCPLibrary();
		}

		private void ExitFromApp ()
		{
			Model.ExitFromApp();
		}
	}
}
