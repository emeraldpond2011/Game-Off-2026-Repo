using UnityEngine;
using static UnityEditor.VersionControl.Asset;

public class ClickAndDragScript : MonoBehaviour
{
    public bool hovered;
    public string States = "notSelected";
    public bool handsFull = false;
    void Update()
    {
        ClickAndDrag();
    }
    public void ClickAndDrag()
    {
        if (Input.GetMouseButtonDown(0) && hovered == true)
        {
                if (States == "notSelected")
                {
                    States = "enterSelected";
                }
                if (States == "Selected")
                {
                    States = "exitSelected";
                }
        }

        if (Input.GetMouseButtonUp(0))
        {

            if (States == "enterSelected")
            {
                States = "Selected";
                handsFull = true;
            }
            if (States == "exitSelected")
            {
                States = "notSelected";
            }
        }
        if (States == "Selected")
        {
            Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mouseposition;
        }
        if (States == "notSelected")
        {
                transform.position = transform.position;
        }
    }
    private void OnMouseEnter()
    {
        hovered = true;
    }
    private void OnMouseExit()
    {
        hovered = false;
    }
}
