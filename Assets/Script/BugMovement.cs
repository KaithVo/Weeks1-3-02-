using UnityEngine;

public class BugMovement : MonoBehaviour
{
    //start and end position for the bug
    private Vector3 startPos;
    private Vector3 endPos;

    //bug speed
    public float moveSpeed = 0.5f;

    // set for random
    private float t; 

    void Start()
    {
      
    }

    void Update()
    {
        //increase t over time
        t += Time.deltaTime * moveSpeed;

        // move bug from start to end
        transform.position = Vector3.Lerp(startPos, endPos, t);

    }


}
