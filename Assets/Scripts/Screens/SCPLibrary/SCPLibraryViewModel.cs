using SCPVisualization.MVVM;
using UnityEngine.UIElements;

namespace SCPVisualization.UI.Screens
{
	public class SCPLibraryViewModel : ViewModel<SCPLibraryModel>
	{
		private Button ReturnToMenuButton { get; set; }
		
		private void Awake ()
		{
			Model.OnGetRootVisualElement += () => View.rootVisualElement;
			ReturnToMenuButton = View.rootVisualElement.Q<Button>("ReturnToMenu");
		}
		
		private void OnEnable ()
		{
			ReturnToMenuButton.clicked += ReturnToMenu;
		}
		
		private void OnDisable ()
		{
			ReturnToMenuButton.clicked -= ReturnToMenu;
		}

		private void ReturnToMenu ()
		{
			Model.ReturnToMenu();
		}
	}
}