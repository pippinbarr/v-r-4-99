using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    private string _sceneName = "TheDesert";

    private AsyncOperation _asyncOperation;

    private IEnumerator LoadSceneAsyncProcess()
    {
        // Begin to load the Scene you have specified.
        this._asyncOperation = SceneManager.LoadSceneAsync(_sceneName);

        // Don't let the Scene activate until you allow it to.
        this._asyncOperation.allowSceneActivation = false;

        while (!this._asyncOperation.isDone)
        {
            Debug.Log($"[scene]:{_sceneName} [load progress]: {this._asyncOperation.progress}");

            yield return null;
        }
    }

    private void Start()
    {
      StartCoroutine(this.LoadSceneAsyncProcess());
    }

    private void Update()
    {
        if (this._asyncOperation != null)
        {
            Debug.Log("Allowed Scene Activation");

            this._asyncOperation.allowSceneActivation = true;
        }
    }
}
