using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPauseManager : PauseManager
{
    public override void Return()
    {
        SceneManager.LoadScene("Map");
    }
}
