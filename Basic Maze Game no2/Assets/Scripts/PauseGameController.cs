using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGameController : MonoBehaviour {

    public GameObject canvas;
    public GameObject player;

    void Start () {

    }
	
	void Update () {
        if (Input.GetKey(KeyCode.P))
        {
            Pause();
        }
    }

    public void Pause()
    {
        Cursor.visible = true; // enabled mouse pointer
        canvas.SetActive(true);
        player.SetActive(false);
    }

    public void UnPause()
    {
        Cursor.visible = false; // disable mouse pointer
        canvas.SetActive(false);
        player.SetActive(true);
    }

}
