using UnityEngine;
using UnityEngine.SceneManagement;

public class ParticleExitBehavior : MonoBehaviour
{

    [SerializeField]
    private int levelToLoad; // L'index du prochain niveau à charger

    [SerializeField]
    private bool autoIndex; // Paramètre indiquant si l'on souhaite que le jeu choisit l'index de lui-même ou non

    /* On contrôle la valeur de autoIndex
     * Si c'est vrai, on initialise le LevelToLoad avec l'index du prochain niveau après celui-ci.
    */

    private void Start()
    {
        if (autoIndex)
        {
            levelToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        }
        
    }

    /* Lorsqu'un objet entre en collision avec celui-ci, on vérifie s'il s'agit du joueur.
     * Le cas échéant, on met à jour la valeur stocké dans le PlayerPref et on charge le prochain niveau.
     * 
     */ 

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("DernierNiveau", levelToLoad);
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
