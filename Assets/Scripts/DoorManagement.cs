using UnityEngine;

public class DoorManagement : MonoBehaviour
{
    public bool CanOpen = false;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && CanOpen)
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
