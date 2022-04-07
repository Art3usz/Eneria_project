using UnityEngine;
[RequireComponent (typeof (DontDestroy))]
public class GameManager : MonoBehaviour {

    private static GameManager _instance;
    public static GameManager instance {
        get {
            if (_instance == null) {
                _instance = FindObjectOfType<GameManager> ();
            }

            if (_instance == null) {
                GameObject go = new GameObject ("GameManager");
                go.AddComponent<GameManager> ();
            }
            return _instance;
        }
    }

    public void Awake () {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
            Destroy (gameObject);
    }
}