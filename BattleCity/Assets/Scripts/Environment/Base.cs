using UnityEngine;


public class Base : MonoBehaviour
{
    [SerializeField] private GameObject lose; 
    [SerializeField] private GameObject mainBase; 

    private void Update()
    {
        if (mainBase == null)
        {
            lose.gameObject.SetActive(true);
        }
    }
}
