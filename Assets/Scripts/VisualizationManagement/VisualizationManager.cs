using SCPVisualization.ScreensManagement;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace SCPVisualization.VisualizationManagement
{
	public class VisualizationManager : MonoBehaviour
	{
		[field: SerializeField]
		private ScreenManager ScreenManager { get; set; }
		[field: SerializeField]
		private ScreenNamePicker SCPLibraryScreenPicker { get; set; }
		
		private AsyncOperationHandle<SceneInstance> ActiveScene { get; set; }
		
		public void LoadVisualization (AssetReference visualizationScene)
		{
			ScreenManager.CloseAllScreens();
			AsyncOperationHandle<SceneInstance> sceneLoadingProcess = visualizationScene.LoadSceneAsync(LoadSceneMode.Additive);
			
			sceneLoadingProcess.Completed += sceneHandle =>
			{
				if (sceneHandle.Status == AsyncOperationStatus.Succeeded)
				{
					ActiveScene = sceneHandle;
					SceneManager.SetActiveScene(sceneHandle.Result.Scene);
					
					Visualization visualizationObject = FindObjectOfType<Visualization>();
					visualizationObject.OnVisualizationEnd += EndVisualization;
				}
			};
		}

		private void EndVisualization ()
		{
			Addressables.UnloadSceneAsync(ActiveScene);
			ScreenManager.ShowScreen(SCPLibraryScreenPicker.ScreenName);
		}
	}
}