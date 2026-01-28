using UnityEngine;

public class CandleFire : MonoBehaviour
{
    //Calling candle light sprite
    public Sprite light1;
    public Sprite light2;

    // calling spriteRender
    public SpriteRenderer spriteRenderer;

    //change sprite speed
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        //if over 0.5f, change sprite1 to sprite 2 back and forth
        if (t >= 0.5f )
        {
            spriteRenderer.sprite = light1;
        }
        else
        {
            spriteRenderer.sprite = light2;
        }
    }
}
