using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete3D : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("VictoryMenu", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("PauseMenu");
        }
    }
}
