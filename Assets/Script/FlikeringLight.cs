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
    private float flickerTime; 

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
    void Flickeringlight()// https://www.google.com/search?q=alpha+animation+curve+unity&sca_esv=dfd8ad97cdb7fcc2&rlz=1C5CHFA_enCA1026CA1026&sxsrf=ANbL-n4cs2UhHW8DzpZygbe8V6-kAJwHpw%3A1769565476840&ei=JG15aYyMM7Kew8cPgI3t8QQ&ved=0ahUKEwiMrp2Nka2SAxUyz_ACHYBGO04Q4dUDCBE&uact=5&oq=alpha+animation+curve+unity&gs_lp=Egxnd3Mtd2l6LXNlcnAiG2FscGhhIGFuaW1hdGlvbiBjdXJ2ZSB1bml0eTIFECEYoAEyBRAhGJ8FMgUQIRifBTIFECEYnwUyBRAhGJ8FMgUQIRifBTIFECEYnwUyBRAhGJ8FMgUQIRifBTIFECEYnwVIpBVQxgZYnBRwAXgBkAEAmAGgAaABsQWqAQMxLjW4AQPIAQD4AQGYAgegAs4FwgIKEAAYsAMY1gQYR8ICBxAhGKABGAqYAwCIBgGQBgiSBwMyLjWgB-IlsgcDMS41uAfMBcIHAzAuN8gHDoAIAA&sclient=gws-wiz-serp
    {
        //t is just a loop phase to go back and forth
        //flickertime is the real goat, real clock
        float t = flickerTime * 1f;
        flickerTime += Time.deltaTime * speed;


        //aplly alpha witout changing colpr
        Color currentColor = SpriteRenderer.color;
        currentColor.a = Mathf.Lerp (minAlpha,maxAlpha, flickeringCurve.Evaluate(t));
        SpriteRenderer.color = currentColor;
    }
}
