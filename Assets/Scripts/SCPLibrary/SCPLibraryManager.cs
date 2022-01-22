using UnityEngine;
namespace SCPLibrary
{
	public class SCPLibraryManager : MonoBehaviour
	{
		[field: SerializeField]
		public SCPMetadata[] MetadataCollection { get; private set; }
		
		public void StartVisualization (uint ID)
		{
			Debug.Log(ID);
		}
	}
}