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
			ListView scpButtonsList = GetSCPButtonsListView();
			scpButtonsList.makeItem = MakeSCPButton;
			scpButtonsList.bindItem = BindSCPButton;
			scpButtonsList.itemsSource = LibraryManager.MetadataCollection;
		}

		private ListView GetSCPButtonsListView ()
		{
			VisualElement rootScreenElement = OnGetRootVisualElement?.Invoke();
			ListView scpButtonsList = rootScreenElement.Q<ListView>("SCPList");

			return scpButtonsList;
		}

		private VisualElement MakeSCPButton ()
		{
			TemplateContainer newSCPButton = SCPButtonTemplate.Instantiate();
			SCPButtonController newSCPButtonController = new();
			newSCPButton.userData = newSCPButtonController;
			newSCPButtonController.SetVisualElement(newSCPButton);

			return newSCPButton;
		}

		private void BindSCPButton (VisualElement buttonElement, int buttonIndex)
		{
			(buttonElement.userData as SCPButtonController)?.SetSCPData(LibraryManager.MetadataCollection[buttonIndex].ID, LibraryManager);
		}
	}
}