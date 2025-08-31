using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PausePanel;
    public TMP_Text LevelLabel;

    private string _sceneName;

    public void Start()
    {
        _sceneName = SceneManager.GetActiveScene().name;
        LevelLabel.text = _sceneName;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!PausePanel.activeInHierarchy)
            {
                PauseGame();
            }
            else if (PausePanel.activeInHierarchy)
            {
                ContinueGame();
            }
        }
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        //Disable scripts that still work while timescale is set to 0
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        //enable the scripts again
    }
    public void OnRestartButton()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
