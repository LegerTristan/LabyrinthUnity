using UnityEngine;

public class WheelBallBehavior : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f; // Vitesse de déplacement

    public Transform target; // La cible attribué à l'objet
    
    /* À chaque frame, on fait déplacer vers l'avant l'objet vers sa destination "target".
     * Il est possible de définir la vitesse de déplacement.
     */
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

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
