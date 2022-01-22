using UnityEngine;

namespace SCPVisualization.MVVM
{
	public class ViewModel<TModel> : MonoBehaviour where TModel : Model
	{
		[field: SerializeField]
		protected TModel Model { get; private set; }
	}
}