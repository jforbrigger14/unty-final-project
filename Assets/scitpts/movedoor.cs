using UnityEngine;

public class movedoor : MonoBehaviour



{
    
    private float speed = 0f;
    
    private GameObject door;
    private GameObject doordeleter;

    private Vector3 doorPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorPosition = door.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToDoorDeleter();
    }

    private void MoveToDoorDeleter()
    {
        transform.position = Vector3.MoveTowards(transform.position, doorPosition, speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(door);
        Destroy(doordeleter);
    }
    
}
