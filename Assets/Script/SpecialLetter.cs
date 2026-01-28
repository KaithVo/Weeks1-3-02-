using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpecialLetter : MonoBehaviour
{
    private bool mouseIsOverMe = false;
    public Color col;
    public SpriteRenderer spriteRenderer; //for sprite chnge

    //scales value
    public Vector3 originalScale;
    public Vector3 IsExpanding = new Vector3(1.5f, 1.5f,1.5f);
  

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Pickrandomcolor();

        //save the original scale
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Detection();
        Animating();

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
        col = Random.ColorHSV();
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

    private float speed = 2f;
    //time
    private float t = 0;
    public AnimationCurve curve;

    //animation curve for size
    void Animating() //https://zh.esotericsoftware.com/forum/d/3825-unity-random-bone-explosion/2
    {
        //if mouse is over than the animation happens
        if (mouseIsOverMe)
        {
            //increase t 
            t += Time.deltaTime * speed;
        }
        else
        {
            //decrease t
            t -= Time.deltaTime * speed;

        }

        //clamp instead of resetting 
        t = Mathf.Clamp01(t);

        transform.localScale = Vector3.Lerp(originalScale, IsExpanding, curve.Evaluate(t));
    }
}
