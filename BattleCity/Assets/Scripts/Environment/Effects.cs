using System.Collections;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public float time;
    private void Start()
    {
        StartCoroutine(Death());
    }
    IEnumerator Death()

    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
