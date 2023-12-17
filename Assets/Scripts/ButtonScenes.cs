using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScenes : MonoBehaviour
{
    public void SelectLevel(string sceneDifficulty)
    {
        // Loads a scene on input
        SceneManager.LoadScene(sceneDifficulty);
    }
}
