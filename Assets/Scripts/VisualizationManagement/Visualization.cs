using System;
using UnityEngine;

namespace SCPVisualization.VisualizationManagement
{
	public class Visualization : MonoBehaviour
	{
		public event Action OnVisualizationEnd = delegate { };

		public void EndVisualization ()
		{
			OnVisualizationEnd.Invoke();
		}
	}
}