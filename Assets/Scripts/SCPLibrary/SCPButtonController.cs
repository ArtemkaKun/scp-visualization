using UnityEngine.UIElements;

namespace SCPLibrary
{
	public class SCPButtonController
	{
		private Button SCPButton { get; set; }

		public void SetVisualElement(VisualElement rootElement)
		{
			SCPButton = rootElement.Q<Button>("SCPButton");
		}

		public void SetCharacterData(uint ID, SCPLibraryManager libraryManager)
		{
			SCPButton.text = $"SCP-{ID:D3}";
			SCPButton.clicked += OnSCPButtonOnclicked;

			void OnSCPButtonOnclicked ()
			{
				SCPButton.clicked -= OnSCPButtonOnclicked;
				libraryManager.StartVisualization(ID);
			}
		}
	}
}