using UnityEngine;

public class deletedoor : MonoBehaviour
{
    [SerializeField]
    private GameObject door;
    [SerializeField]
    private GameObject doordeleter;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(door);
        Destroy(doordeleter);
    }
}
