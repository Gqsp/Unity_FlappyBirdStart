using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyController : MonoBehaviour
{
    // Votre Code ici

    // Appeler quand le joueur meurt
    private void Reset() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
