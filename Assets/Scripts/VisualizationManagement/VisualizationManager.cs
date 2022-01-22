using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace VisualizationManagement
{
	public class VisualizationManager : MonoBehaviour
	{
		private AsyncOperationHandle<SceneInstance> ActiveScene { get; set; }
		
		public void LoadVisualization (AssetReference visualizationScene)
		{
			AsyncOperationHandle<SceneInstance> sceneLoadingProcess = visualizationScene.LoadSceneAsync(LoadSceneMode.Additive);
			
			sceneLoadingProcess.Completed += sceneHandle =>
			{
				if (sceneHandle.Status == AsyncOperationStatus.Succeeded)
				{
					ActiveScene = sceneHandle;
					SceneManager.SetActiveScene(sceneHandle.Result.Scene);
					
					Visualization visualizationObject = FindObjectOfType<Visualization>();
					visualizationObject.OnVisualizationEnd += EndVisualization;
					visualizationObject.StartVisualization();
				}
			};
		}

		private void EndVisualization ()
		{
			Addressables.UnloadSceneAsync(ActiveScene);
		}
	}
}