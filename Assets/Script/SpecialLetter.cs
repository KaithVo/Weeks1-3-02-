using System.Security.Cryptography;
using Unity.VisualScripting;
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
    public AnimationCurve curve;

    //time
    public float t = 0;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Pickrandomcolor();
    }

    // Update is called once per frame
    void Update()
    {
        Detection();

        //change color
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
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

    //animation curve for size
    void Animating() //https://zh.esotericsoftware.com/forum/d/3825-unity-random-bone-explosion/2
    {
        //if mouse is over than the animation happens
        if (mouseIsOverMe)
        {
            t += Time.deltaTime;
        }
        else
        {
            t -= Time.deltaTime;

        }
        if (t > 1)
        {
            t = 0;
        }
        transform.localScale = Vector2.Lerp(originalScale, IsExpanding, curve.Evaluate(t));
    }
}
