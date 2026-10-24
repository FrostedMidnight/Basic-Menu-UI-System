using UnityEngine;

public abstract class PauseManager : MenuManager
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGameActive = true;
        mainMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isGameActive)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        isGameActive = false;
        mainMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        isGameActive = true;
        mainMenu.SetActive(false);
    }

    public abstract void Return();
}
