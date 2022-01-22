using SCPVisualization.MVVM;
using UnityEngine.UIElements;

namespace SCP_001.UI
{
	public class InGameViewModel : ViewModel<InGameModel>
	{
		private Button ExitButton { get; set; }
		private Button RestartButton { get; set; }
		
		private void Awake ()
		{
			ExitButton = View.rootVisualElement.Q<Button>("Exit");
			RestartButton = View.rootVisualElement.Q<Button>("Restart");
		}
		
		private void OnEnable ()
		{
			ExitButton.clicked += Model.ExitVisualization;
			RestartButton.clicked += Model.RestartVisualization;
		}
		
		private void OnDisable ()
		{
			ExitButton.clicked -= Model.ExitVisualization;
			RestartButton.clicked -= Model.RestartVisualization;
		}
	}
}