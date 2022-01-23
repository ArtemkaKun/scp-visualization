using SCPVisualization.MVVM;
using SCPVisualization.VisualizationManagement;
using UnityEngine;

namespace SCPVisualization.SCP_001
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