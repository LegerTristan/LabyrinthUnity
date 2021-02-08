using UnityEngine;

public class ReturnScript : MonoBehaviour
{
    [SerializeField]
    private Transform target; // La cible qui va être attribué à l'objet

    [SerializeField]
    private WheelBallBehavior ballBehavior; // L'objet auquel donner la cible

    /* Lorsque l'objet entre dans le collider, le trigger se déclenche.
     * Si celui-ci est une balle, on redéfinit sa cible.
     */
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballBehavior.target = target;
        }
    }
}
