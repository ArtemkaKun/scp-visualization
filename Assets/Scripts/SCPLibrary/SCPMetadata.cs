using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SCPLibrary
{
	[CreateAssetMenu(fileName = ASSET_NAME, menuName = "SCPLibrary/" + ASSET_NAME, order = 0)]
	public class SCPMetadata : ScriptableObject
	{
		[field: SerializeField]
		public uint ID { get; private set; }
		[field: SerializeField]
		public AssetReference SceneReference { get; private set; }
		
		private const string ASSET_NAME = nameof(SCPMetadata);
	}
}