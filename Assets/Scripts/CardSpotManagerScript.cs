using UnityEngine;

public class CardSpotManagerScript : MonoBehaviour
{
    public string attachedCardLetter = string.Empty;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        attachedCardLetter = collision.gameObject.GetComponent<CardManagerScript>().cardLetter;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        attachedCardLetter = string.Empty;
    }
}
