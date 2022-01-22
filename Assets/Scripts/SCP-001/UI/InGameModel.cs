using SCPVisualization.MVVM;
using UnityEngine;
using VisualizationManagement;

namespace SCP_001.UI
{
	public class InGameModel : Model
	{
		[field: SerializeField]
		private Visualization VisualizationController { get; set; }
		
		public void RestartVisualization () { }

		public void ExitVisualization ()
		{
			VisualizationController.EndVisualization();
		}
	}
}