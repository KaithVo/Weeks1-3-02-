using UnityEngine;
using UnityEngine.InputSystem;


public class SpecialLetter : MonoBehaviour
{
    public bool mouseIsOverMe = false;
    public Color col;
    public SpriteRenderer spriteRenderer; //for sprite chnge

    //scales value
    public Vector2 originalScale;
    public Vector2 IsExpanding = new Vector2(1.5f, 1.5f);

    //animation control using animation curve
    private float animationSpeed = 3f;
    public AnimationCurve animationCurve;

    //time
    public float t = 0;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Detection();

        if (spriteRenderer.bounds.Contains(mousePos) == true)
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
    void Pickrandomcolor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
    void Detection()
    {
        //get the mouse position (in pixels) and convert it to world space (in meters)
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //get the distance between transform.position and the mouse position
        float distance = Vector2.Distance(transform.position, mousePos);

        //if that distance is small (<1) then set mouseIsOverMe to true
        if (distance < 1)
        {
            mouseIsOverMe = true;

        }
        else
        {
            mouseIsOverMe = false;

        }
    }
}
