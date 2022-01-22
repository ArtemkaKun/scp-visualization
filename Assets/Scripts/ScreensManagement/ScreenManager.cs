using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

namespace SCPVisualization.ScreensManagement
{
	public class ScreenManager : SerializedMonoBehaviour
	{
		[field: NonSerialized, OdinSerialize, OnValueChanged(nameof(SetNamesToAsset), true)]
		private Dictionary<string, UIDocument> NameScreenObjectMap { get; set; } = new();
		[field: SerializeField]
		private ScreenNames Names { get; set; }
		[field: SerializeField, ValueDropdown(nameof(GetScreenNames))]
		private string DefaultScreen { get; set; }

		public void ShowScreen (string screenName)
		{
			if (NameScreenObjectMap.ContainsKey(screenName) == true)
			{
				foreach ((string cachedName, UIDocument cachedScreenObject) in NameScreenObjectMap)
				{
					cachedScreenObject.rootVisualElement.style.display = cachedName == screenName ? DisplayStyle.Flex : DisplayStyle.None;
				}
			}
		}

		private void Awake ()
		{
			ShowScreen(DefaultScreen);
		}

		private void SetNamesToAsset ()
		{
			List<string> newNames = new(NameScreenObjectMap.Count);

			foreach (KeyValuePair<string, UIDocument> nameObjectPair in NameScreenObjectMap)
			{
				newNames.Add(nameObjectPair.Key);
			}

			Names.SetNames(newNames);
		}

		private IEnumerable<string> GetScreenNames ()
		{
			return Names.Names;
		}
	}
}