// Description: When player push any key, go to lobby.
// Author: https://github.com/KaRU3-dev
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour {

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Clicked!!");
            SceneManager.LoadScene("Lobby");
        }
    }
}
