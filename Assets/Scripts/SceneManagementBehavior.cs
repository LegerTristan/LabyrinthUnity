using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementBehavior : MonoBehaviour
{

    // Lance la scène Level_01
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_01");
    }

    /* On vérifie s'il y a déjà une sauvegarde d'un niveau.
     * Si oui, on lance la scène sauvegardé
     * Sinon, on lance la scène Level_01
     */
    public void ContinueGame()
    {
        int levelToLoad = PlayerPrefs.GetInt("DernierNiveau");

        if(levelToLoad > 1)
        {
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            SceneManager.LoadScene("Level_01");
        }
        
    }

    // Quitte le jeu
    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
