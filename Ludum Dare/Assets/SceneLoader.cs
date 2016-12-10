using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class SceneLoader : MonoBehaviour {

	public int SceneToLoad;
	public string Commentaire;
	private bool loadScene = false;
	public Text loadingText;

	void Start ()
	{
		loadScene = true;
		loadingText.text = "Loading...";
		StartCoroutine(LoadNewScene());
	}
	IEnumerator LoadNewScene() {
		// Start an asynchronous operation to load the scene that was passed to the LoadNewScene coroutine.
		AsyncOperation async = EditorSceneManager.LoadSceneAsync (SceneToLoad);
		// While the asynchronous operation to load the new scene is not yet complete, continue waiting until it's done.
		while (!async.isDone) {
			yield return null;
		}
	}
}
