using UnityEngine;

public class SpikeBallBehavior : MonoBehaviour
{
    /* Vérifie si l'acteur qui rentre en collision avec l'objet est bien le perso.
     * Si oui, on appelle la méthode GameOver()
     */
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
        }
    }
}
