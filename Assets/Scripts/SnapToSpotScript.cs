using UnityEngine;

public class SnapToSpotScript : MonoBehaviour
{
    public ClickAndDragScript clickScript;
    public bool colliding = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        colliding = true;
        if (collision.gameObject.tag == "Card Spot" && clickScript.States == "notSelected" && collision.gameObject.GetComponent<CardSpotManagerScript>().attachedCardLetter != string.Empty)
        {
            transform.position = collision.transform.position;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Card Spot" && clickScript.States == "notSelected")
        {
            transform.position = collision.transform.position;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        colliding = false;
    }
}
