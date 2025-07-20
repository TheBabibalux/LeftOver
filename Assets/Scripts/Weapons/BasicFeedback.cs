using System.Collections;
using UnityEngine;

public class BasicFeedback : MonoBehaviour
{
    public float lifeDuration = 1;

    private void Awake()
    {
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(lifeDuration);

        Destroy(gameObject);
    }
}
