
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //move the square
        Vector3 newPosition = transform.position;
        newPosition.x += speed;
        transform.position = newPosition;

        //check if the square is at the edge of the screen
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 | screenPos.x > Screen.width)
        {
            //Y: multiply the speed by -1
            speed = speed * -1;
        }
        
    }
}
