using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f, rotationSpeed = 100f; // La vitesse de déplacement et de rotation
    private float currentSpeed; // La vitesse actuelle

    [SerializeField]
    private GameObject imgGameOver; // Le composant image du GameOver

    /* Chaque seconde on vérifie si la touche LeftShift est pressée.
     * Le cas échéant, on double la vitesse actuelle.
     * Sinon, on laisse la vitesse telle quelle.
     * 
     * Chaque seconde, on met à jour la rotation et la position du perso en fonction de sa vitesse
     * de déplacement et de rotation, de la vitesse d'écoulement du temps.
     * 
     * Le déplacement est contrôlé par l'axe vertical et le vecteur directeur droite
     * qui indique respectivement la valeur de saisie des contrôles (soit 0, soit 1), et l'orientation du personnage.
     * 
     * La rotation est contrôle par l'axe horizontale et le vecteur directeur face pour les mêmes raisons qu'au dessus.
     */

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = speed * 2;
        }
        else
        {
            currentSpeed = speed;
        }
        transform.Rotate(Vector3.up * rotationSpeed * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.right * currentSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
    }

    // Active l'image de GameOver, et déclenche une coroutine gérant le chargement du menu.

    public void GameOver()
    {
        imgGameOver.SetActive(true);
        StartCoroutine(LoadMenu());
    }

    // Coroutine qui charge la scène Menu au bout de 2 secondes.
    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu");
    }
}
