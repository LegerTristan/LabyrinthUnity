using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    private int startCountDown = 60; //Temps imparti pour réaliser le niveau

    [SerializeField]
    private Text textCountDown; // Texte affichant le temps imparti

    // Déclenche le timer et sa Coroutine
    private void Start()
    {
        textCountDown.text = "Time Left : " + startCountDown;
        StartCoroutine(Decrement());
    }

    /* La coroutine qui décremente de 1 le timer chaque seconde.
     * Lorsque la bouucle est terminée, on appelle la méthode GameOver() du player.
     */
    IEnumerator Decrement()
    {
        while(startCountDown > 0)
        {
            yield return new WaitForSeconds(1f);
            startCountDown--;
            textCountDown.text = "Time Left : " + startCountDown;
        }

        GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
    }
}
