using UnityEngine.UIElements;

namespace SCPVisualization.SCPLibrary
{
	public class SCPButtonController
	{
		private Button SCPButton { get; set; }

		public void SetVisualElement(VisualElement rootElement)
		{
			SCPButton = rootElement.Q<Button>("SCPButton");
		}

		public void SetSCPData(uint ID, SCPLibraryManager libraryManager)
		{
			SCPButton.text = $"SCP-{ID:D3}";
			SCPButton.clicked += ReactOnSCPButtonClicked;

			void ReactOnSCPButtonClicked ()
			{
				SCPButton.clicked -= ReactOnSCPButtonClicked;
				libraryManager.StartVisualization(ID);
			}
		}
	}
}