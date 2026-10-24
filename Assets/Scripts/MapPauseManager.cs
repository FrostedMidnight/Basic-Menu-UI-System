using UnityEngine;
using UnityEngine.SceneManagement;

public class MapPauseManager : PauseManager
{
    public override void Return()
    {
        SceneManager.LoadScene("Title");
    }

    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
}
