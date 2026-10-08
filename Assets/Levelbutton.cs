using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public string LevelToLoad;

    public void loadLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(LevelToLoad);

    }

}
