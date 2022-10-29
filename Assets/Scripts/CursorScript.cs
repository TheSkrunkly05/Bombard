using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public Texture2D cursor;

    void Awake()
    {
        DefaultCur();
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void ChangeCrsr (Texture2D cursorType)
    {
        Vector2 hotspot = new Vector2(cursorType.width / 2, 
        cursorType.height / 2);
        Cursor.SetCursor(cursorType, hotspot, CursorMode.Auto);
    }

    public void DefaultCur()
    {
        ChangeCrsr(cursor);
    }
}
