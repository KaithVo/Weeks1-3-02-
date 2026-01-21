using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] barrels;
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
            PickRandomSprite();
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
    }

    void PickRandomColour()
    {
        spriteRenderer.color = Random.ColorHSV(); 
    }
    void PickRandomSprite()
    {
        //get a random numder between 0 to 2
        randomNumder = Random.Range(0, barrels.Length);
        //use that to set the sprite
        spriteRenderer.sprite = barrels[randomNumder];
    }
}
