using UnityEngine;

public class DoorManagement : MonoBehaviour
{
    public bool CanOpen = false; // Est-ce qu'on peut ouvrir la porte ?

    [SerializeField]
    private AudioClip soundOpen, soundDenied; // Les différents sons joués

    [SerializeField]
    private Animator animator; // L'animator qui gère l'animation

    [SerializeField]
    private GameObject particle; // Les particles de lumière liées à la porte

    private AudioSource src; // La source audio

    // On initialise l'audi source au réveil du composant
    private void Awake()
    {
        src = GetComponent<AudioSource>();
    }

    /* Lorsqu'on active le trigger, on vérifie s'il s'agit du joueur et si on peut ouvrir la porte.
     * Le cas échant, on active l'animation, le son associé et on ouvre la porte.
     * Sinon, on déclenche un son signalant que la porte ne s'ouvre pas
     */
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && CanOpen)
        {
            animator.enabled = true;
            particle.SetActive(true);
            src.PlayOneShot(soundOpen);
        }
        else
        {
            src.PlayOneShot(soundDenied);
        }
    }
}
