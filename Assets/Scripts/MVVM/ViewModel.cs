using UnityEngine;
using UnityEngine.UIElements;

namespace SCPVisualization.MVVM
{
	public class ViewModel<TModel> : MonoBehaviour where TModel : Model
	{
		[field: SerializeField]
		protected TModel Model { get; private set; }
		[field: SerializeField]
		protected UIDocument View { get; private set; }
	}
}