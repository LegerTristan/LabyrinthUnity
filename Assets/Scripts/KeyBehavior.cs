using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            GameObject.Find("DoorTrigger").GetComponent<DoorManagement>().CanOpen = true;
            Destroy(transform.parent.gameObject);
        }
    }
}
