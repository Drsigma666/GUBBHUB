using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.TimeZoneInfo;

public class Main_menu : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 1f;

    public void playGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    IEnumerator LoadScene(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
