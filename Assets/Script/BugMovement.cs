using UnityEngine;

public class BugMovement : MonoBehaviour
{
    //start and end position for the bug
    public float speed = 1;

    // 
    void Start()
    {
      
    }

   // Update is called once per frame
    void Update()
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += speed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
    
}
