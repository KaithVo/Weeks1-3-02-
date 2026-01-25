using UnityEngine;

public class FirstScript : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += 0.1f;
        transform.position = newPosition;
    }

}