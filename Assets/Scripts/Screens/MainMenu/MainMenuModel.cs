using SCPVisualization.MVVM;
using UnityEngine;

namespace SCPVisualization.UI.Screens
{
	public class MainMenuModel : Model
	{
		public void OpenSCPLibrary ()
		{
			Debug.Log("SCP Library");
		}

		public void ExitFromApp ()
		{
			Debug.Log("Exit");
		}
	}
}