using System.Globalization;
using System.Runtime.ExceptionServices;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.VersionControl.Asset;

public class ClickAndDragScript : MonoBehaviour
{
    public bool hovered;
    public string States = "notSelected";
    public GameManagerScript gameManager;
    public string cardLetter;
    void Update()
    {
        ClickAndDrag();
    }
    public void ClickAndDrag()
    {
        if (Input.GetMouseButtonDown(0) && hovered == true)
        {
                if (States == "notSelected" && gameManager.cardInHand == string.Empty)
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

            cardLetter = gameObject.GetComponent<CardManagerScript>().cardLetter;
            gameManager.cardInHand = cardLetter;
        }
        if (States == "notSelected")
        {
            transform.position = transform.position;
            gameManager.cardInHand = string.Empty;
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
