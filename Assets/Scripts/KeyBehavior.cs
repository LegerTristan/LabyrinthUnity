using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    /*Si un objet entre en collision avec la clé, on vérifie si c'est le joueur.
     * Si c'est le cas, on active la possibilité d'ouvrir la porte et on joue le son associé à la clé.
     * Puis on désactive le rendu et la collision de la clé, puis au bout de 1 seconde on l'a détruit
     */
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            GameObject.Find("DoorTrigger").GetComponent<DoorManagement>().CanOpen = true;
            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            Destroy(transform.parent.gameObject, 1f);
        }
    }
}
