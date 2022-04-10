using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneManagment {
    public static void loadNewScene (int nrOfScene) => SceneManager.LoadSceneAsync (nrOfScene);
    public static void loadNewScene (string nameOfScene) => SceneManager.LoadSceneAsync (nameOfScene);
    public static void newGame () => SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex + 1);
    public static void close()=>Application.Quit();
}