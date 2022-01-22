using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace SCPVisualization.ScreensManagement
{
	public class ScreenManager : SerializedMonoBehaviour
	{
		[field: NonSerialized, OdinSerialize, OnValueChanged(nameof(SetNamesToAsset), true)]
		private Dictionary<string, GameObject> NameScreenObjectMap { get; set; } = new();
		[field: SerializeField]
		private ScreenNames Names { get; set; }
		[field: SerializeField, ValueDropdown(nameof(GetScreenNames))]
		private string DefaultScreen { get; set; }

		public void ShowScreen (string screenName)
		{
			if (NameScreenObjectMap.ContainsKey(screenName) == true)
			{
				foreach ((string cachedName, GameObject cachedScreenObject) in NameScreenObjectMap)
				{
					cachedScreenObject.SetActive(cachedName == screenName);
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

			foreach (KeyValuePair<string, GameObject> nameObjectPair in NameScreenObjectMap)
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