using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    
        void Start()
    {
        //spriteRenderer.color = Color.red;
    }
        void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        //{
        //  //PickARandomColour();
        //}

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
    }

    void PickRandomColour()
    {
        spriteRenderer.color = Random.ColorHSV(); 
    }
}
