using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LoadScene {
    public static void loadNewScene (int nrOfScene) => SceneManager.LoadSceneAsync (nrOfScene);

    public static void loadNewScene (string nameOfScene) => SceneManager.LoadSceneAsync (nameOfScene);
}