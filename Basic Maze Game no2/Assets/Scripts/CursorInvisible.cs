using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorInvisible : MonoBehaviour {

    public void Awake()
    {
        Cursor.visible = false;
    }
}
