using UnityEngine;

public class movetodoor : MonoBehaviour



{

    private float speed = 2f;
    [SerializeField] private Transform door;


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
        transform.position = Vector3.MoveTowards(transform.position, door.position, speed * Time.deltaTime);
    }
}