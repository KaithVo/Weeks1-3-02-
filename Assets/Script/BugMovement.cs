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
        //reset time
        t = 0f;
        ResetPath();
    }

    void Update()
    {
        //increase t over time
        t += Time.deltaTime * moveSpeed;

        // move bug from start to end
        transform.position = Vector3.Lerp(startPos, endPos, t);

        //if bug reach end, it restarts
        if (t >= 1f)
        {
            Start();
        }

    }

    void ResetPath()

        
    {
      

        // start at random range and end at random range
        startPos = new Vector3(-10f, Random.Range(-3f, 3f), 0f);
        endPos = new Vector3(10f, 10 + Random.Range(-3f, 3f), 0f);

        //start at the start position
        transform.position = startPos;

        //direction from start to end
        Vector3 direction = endPos - startPos;
    }
}
