using UnityEngine;
using System.Collections;

public class OnHoverCursorChange : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public void OnMouseOver()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    public void OnMouseEnter()
    {
        OnMouseOver();
    }
    public void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
