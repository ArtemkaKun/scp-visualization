using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace SCPVisualization.ScreensManagement
{
	[Serializable]
	public class ScreenNamePicker
	{
		[field: SerializeField, ValueDropdown(nameof(GetScreenNames))]
		public string ScreenName { get; set; }
		
		[field: SerializeField]
		private ScreenNames NamesAsset { get; set; }
		
		private IEnumerable<string> GetScreenNames ()
		{
			return NamesAsset.Names;
		}
	}
}