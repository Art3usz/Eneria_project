using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {
    // Start is called before the first frame update
    public void LoadLv(int nr = 1) => SceneManagment.loadNewScene(nr);
    public void LoadLv(string name = "Menu scene") => SceneManagment.loadNewScene(name);
    public void newGame() => SceneManagment.newGame();
    public void close() => SceneManagment.close();
}