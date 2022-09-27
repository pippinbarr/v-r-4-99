using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    public string _sceneName = "<scene name>";

    private AsyncOperation _asyncOperation;

    private IEnumerator BeginLoad()
    {
      yield return new WaitForSecondsRealtime(time: 1f);

      StartCoroutine(this.LoadSceneAsyncProcess());
    }

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
      StartCoroutine(BeginLoad());
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
