using UnityEngine;
using UnityEngine.SceneManagement;

public class DificulltySelect : MonoBehaviour
{
    // This function is called when the button is clicked
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void RestartLevel()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }
}