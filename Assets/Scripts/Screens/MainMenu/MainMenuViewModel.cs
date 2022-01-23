using SCPVisualization.MVVM;
using UnityEngine.UIElements;

namespace SCPVisualization.Screens
{
	public class MainMenuViewModel : ViewModel<MainMenuModel>
	{
		private Button SCPLibraryButton { get; set; }
		private Button ExitButton { get; set; }
		
		private void Awake ()
		{
			SCPLibraryButton = View.rootVisualElement.Q<Button>("SCPLibrary");
			ExitButton = View.rootVisualElement.Q<Button>("Exit");
		}

		private void OnEnable ()
		{
			SCPLibraryButton.clicked += Model.OpenSCPLibrary;
			ExitButton.clicked += Model.ExitFromApp;
		}
		
		private void OnDisable ()
		{
			SCPLibraryButton.clicked -= Model.OpenSCPLibrary;
			ExitButton.clicked -= Model.ExitFromApp;
		}
	}
}
