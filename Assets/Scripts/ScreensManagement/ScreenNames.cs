using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace SCPVisualization.ScreensManagement
{
	[CreateAssetMenu(fileName = ASSET_NAME, menuName = "ScreensManagement/" + ASSET_NAME, order = 0)]
	public class ScreenNames : ScriptableObject
	{
		[field: SerializeField, ReadOnly]
		public List<string> Names { get; private set; }
		
		private const string ASSET_NAME = nameof(ScreenNames);

		public void SetNames (IEnumerable<string> newNames)
		{
			Names = new List<string>(newNames);
		}
	}
}