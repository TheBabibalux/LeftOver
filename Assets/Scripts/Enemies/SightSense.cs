using StarterAssets;
using UnityEngine;

public class SightSense : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        TPSController playerController = other.GetComponent<TPSController>();

        if (playerController != null)
        {
            GetComponentInParent<Enemy>().target = playerController;
        }
    }
}
