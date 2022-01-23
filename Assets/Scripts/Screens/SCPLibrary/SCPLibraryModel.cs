using System;
using SCPVisualization.MVVM;
using SCPVisualization.SCPLibrary;
using SCPVisualization.ScreensManagement;
using UnityEngine;
using UnityEngine.UIElements;

namespace SCPVisualization.Screens
{
	public class SCPLibraryModel : Model
	{
		public event Func<VisualElement> OnGetRootVisualElement;
		
		[field: SerializeField]
		private ScreenNamePicker MenuScreenPicker { get; set; }
		[field: SerializeField]
		private ScreenManager ScreenManager { get; set; }
		[field: SerializeField]
		private VisualTreeAsset SCPButtonTemplate { get; set; }
		[field: SerializeField]
		private SCPLibraryManager LibraryManager { get; set; }

		public void ReturnToMenu ()
		{
			ScreenManager.ShowScreen(MenuScreenPicker.ScreenName);
		}

		private void OnEnable ()
		{
			VisualElement rootScreenElement = OnGetRootVisualElement?.Invoke();
			ListView scpButtonsList = rootScreenElement.Q<ListView>("SCPList");
			
			scpButtonsList.makeItem = () =>
			{
				TemplateContainer newSCPButton = SCPButtonTemplate.Instantiate();
				SCPButtonController newSCPButtonController = new();
				newSCPButton.userData = newSCPButtonController;
				newSCPButtonController.SetVisualElement(newSCPButton);
				
				return newSCPButton;
			};
			
			scpButtonsList.bindItem = (item, index) =>
			{
				(item.userData as SCPButtonController)?.SetCharacterData(LibraryManager.MetadataCollection[index].ID, LibraryManager);
			};
			
			scpButtonsList.itemsSource = LibraryManager.MetadataCollection;
		}
	}
}