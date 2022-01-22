using System;
using UnityEngine;

namespace VisualizationManagement
{
	public class Visualization : MonoBehaviour
	{
		public event Action OnVisualizationEnd = delegate { };

		public void StartVisualization ()
		{
			Debug.Log("Visualization started");
		}

		public void EndVisualization ()
		{
			OnVisualizationEnd.Invoke();
		}
	}
}