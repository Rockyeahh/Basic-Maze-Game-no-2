using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    public GameObject canvas;


	// Use this for initialization
	void Start () {
        //Canvas canvas = canvas.GetComponent<Canvas>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.P))
        {
            Pause();
        }
    }

    public void Pause()
    {
        speed = 0;
        Cursor.visible = true; // enabled mouse pointer
                               // canvas ticked = 
        canvas.SetActive(true);
    }

    public void UnPause()
    {
        speed = 10; // I will need to find a way to set it to whatever the inspector currently is.
        Cursor.visible = false; // disable mouse pointer
                                // canvas un-ticked = 
        canvas.SetActive(false);
    }

}
