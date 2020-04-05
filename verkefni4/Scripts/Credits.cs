using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    // takki tils að hætta
    public void Quit()
    {
        Application.Quit();
    }
    // takki tils að Spila aftur
    public void RestartGame()
    {
        SceneManager.LoadScene("Main"); // birtist game scene-ið
    }
}
