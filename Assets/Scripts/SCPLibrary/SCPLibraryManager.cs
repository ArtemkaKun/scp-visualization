using SCPVisualization.VisualizationManagement;
using UnityEngine;

namespace SCPVisualization.SCPLibrary
{
	public class SCPLibraryManager : MonoBehaviour
	{
		[field: SerializeField]
		public SCPMetadata[] MetadataCollection { get; private set; }
		[field: SerializeField]
		private VisualizationManager VisualizationManager { get; set; }
		
		public void StartVisualization (uint ID)
		{
			foreach (SCPMetadata metadata in MetadataCollection)
			{
				if (metadata.ID == ID)
				{
					VisualizationManager.LoadVisualization(metadata.SceneReference);
				}
			}
		}
	}
}