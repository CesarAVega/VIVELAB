using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

    public void OpenGame(string name) {
        Application.LoadLevel(name);
    }
}
