using UnityEngine;
using UnityEngine.InputSystem;
using o

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public AudioListener ;
    public int randomNumder; 

    void Start()
    {
        //PickRandomColor();
        PickRandomSprite();
    }
        void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("Try to change the Sprite");
            if (barrels.Count > 0)
            {
                PickRandomSprite();
            }
        }
        //Get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it allign?
        if (spriteRenderer.bounds.Contains(mousePos)== true)
        {
            //use the color variable
            spriteRenderer.color = col;

        }
        else
        {
            //set the color to white
            spriteRenderer.color = Color.white; 
        }
        if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }
    }

    void PickRandomColour()
    {
        spriteRenderer.color = Random.ColorHSV(); 
    }
    void PickRandomSprite()
    {
        //get a random numder between 0 to 2
        randomNumder = Random.Range(0, barrels.Count);
        //use that to set the sprite
        spriteRenderer.sprite = barrels[randomNumder];
    }
}
