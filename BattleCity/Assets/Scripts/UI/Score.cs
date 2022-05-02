using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject victory;
    [SerializeField] private GameObject boss;
    public static int score;

    private void Update()
    {
        scoreText.text = score + "/20";
        if (score >= 20)
        {
            victory.gameObject.SetActive(true);
        }
        if (score >= 5)
        {
            boss.gameObject.SetActive(true);
        }
    }
}
