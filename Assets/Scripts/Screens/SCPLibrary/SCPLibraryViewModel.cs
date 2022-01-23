using SCPVisualization.MVVM;
using UnityEngine.UIElements;

namespace SCPVisualization.Screens
{
	public class SCPLibraryViewModel : ViewModel<SCPLibraryModel>
	{
		private Button ReturnToMenuButton { get; set; }
		
		private void Awake ()
		{
			Model.OnGetRootVisualElement += GetRootVisualElement;
			ReturnToMenuButton = View.rootVisualElement.Q<Button>("ReturnToMenu");
		}
		
		private void OnEnable ()
		{
			ReturnToMenuButton.clicked += Model.ReturnToMenu;
		}
		
		private void OnDisable ()
		{
			ReturnToMenuButton.clicked -= Model.ReturnToMenu;
		}

		private void OnDestroy ()
		{
			if (Model != null)
			{
				Model.OnGetRootVisualElement -= GetRootVisualElement;
			}
		}

		private VisualElement GetRootVisualElement ()
		{
			return View.rootVisualElement;
		}
	}
}