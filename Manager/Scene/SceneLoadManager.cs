using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoadManager : Singleton<SceneLoadManager>
{
    private static bool Loaded { get; set; }
    private static bool OLoaded { get; set; }
    private static bool TLoaded { get; set; }

    [SerializeField] private GameObject canvas;

    public void LoadStartScene()
    {
        if (Loaded) return;

        Loaded = true;
        SceneManager.LoadSceneAsync("Office", LoadSceneMode.Additive);
    }

    public void LoadOfficeScene()
    {
        if (OLoaded) return;

        OLoaded = true;
        TLoaded = false;
        UnloadSceneAsync("Town");
        StartCoroutine(LoadSceneExecute("Office"));
    }

    public void LoadTownScene()
    {
        if (TLoaded) return;

        TLoaded = true;
        OLoaded = false;
        UnloadSceneAsync("Office");
        StartCoroutine(LoadSceneExecute("Town"));
    }

    private void UnloadSceneAsync(string name)
    {
        SceneManager.UnloadSceneAsync(name);
    }

    IEnumerator LoadSceneExecute(string name)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
        asyncLoad.allowSceneActivation = false;

        canvas.SetActive(true);

        while(true)
        {
            yield return null;

            if (asyncLoad.progress >= .9f)
            {
                yield return new WaitForSeconds(1f);
                asyncLoad.allowSceneActivation = true;

                break;
            }
        }

        canvas.SetActive(false);
    }
}
