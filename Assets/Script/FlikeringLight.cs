using System.Security.Cryptography;
using UnityEngine;

public class FlikeringLight : MonoBehaviour
{
    //use the same method in the special letter but in color
    //spriteRender but for Alpha this time
    private SpriteRenderer SpriteRenderer;

    //range for min and max for Alpha
    public float minAlpha = 0.6f;
    public float maxAlpha = 1f;

    //animationCurve ofcours
    private float speed = 2f;
    public AnimationCurve flickeringCurve;
    private float t; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Flickeringlight(); 
    }
    void Flickeringlight()
    {
        t += Time.deltaTime * speed;
        transform.localScale = Vector3.Lerp(minAlpha, maxAlpha, flickeringCurve.Evaluate(t));
    }
}
