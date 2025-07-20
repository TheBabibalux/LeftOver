using StarterAssets;
using UnityEngine;

public class SightSense : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ThirdPersonController playerController = other.GetComponent<ThirdPersonController>();

        if (playerController != null)
        {
            GetComponentInParent<Enemy>().target = playerController;
        }
    }
}
