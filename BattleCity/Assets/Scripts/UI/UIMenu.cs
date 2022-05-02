using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public void StartLVL()
    {
        SceneManager.LoadScene(1);
    } 
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Play()
    {
        Time.timeScale = 1;
    } 
    public void Return()
    { 
        Score.score = 0;
        SceneManager.LoadScene(0);
    }
    public void Boss()
    {
        SceneManager.LoadScene(2);
    }
}
