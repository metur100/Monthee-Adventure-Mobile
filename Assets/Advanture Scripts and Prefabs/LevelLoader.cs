using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreenObj;
    public Slider slider;
    public GameObject [] screens;
    AsyncOperation async;

    int levelIsUnlocked;
    public Button[] buttons;

    void Start()
    {
        levelIsUnlocked = PlayerPrefs.GetInt("levelIsUnlocked", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelIsUnlocked; i++)
        {
            buttons[i].interactable = true;
        }
    }
    public void LoadScreenExample(int lvl)
    {
        StartCoroutine(LoadingScreen(lvl));
    }

    IEnumerator LoadingScreen(int level)
    {
        loadingScreenObj.SetActive(true);
        for(int i = 0; i < screens.Length; i++)
        {
            screens[i].SetActive(false);
        }
        async = SceneManager.LoadSceneAsync(level);
        async.allowSceneActivation = false;

        while (async.isDone == false)
        {
            slider.value = async.progress;
            if (async.progress == 0.9f)
            {
                slider.value = 1f;
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    public void ResetLevels()
    {
        PlayerPrefs.DeleteKey("levelIsUnlocked");
    }
}
