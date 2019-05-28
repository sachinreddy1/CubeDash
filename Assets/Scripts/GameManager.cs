using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    
    public void LevelComplete() {
        Debug.Log("Level Completed.");
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("restart", restartDelay);
        }
    }

    public void restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
