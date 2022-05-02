using UnityEngine;

public class BossDeath : MonoBehaviour
{
    [SerializeField] private GameObject victory;
    [SerializeField] private GameObject boss;

    private void Update()
    {
        if (boss == null)
        {
            victory.gameObject.SetActive(true);
        }
    }
}
