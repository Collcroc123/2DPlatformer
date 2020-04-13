using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    //Brackeys' Transition tutorial
    private int currentScene;
    public Animator transitionFade;
    public float transTime = 1;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transitionFade.SetTrigger("Start");
        yield return new WaitForSeconds(transTime);
        SceneManager.LoadScene(currentScene+1);
    }
}
