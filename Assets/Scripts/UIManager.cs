using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Image inHandItemImageDisplay;
    public Slider reloadSlider;
    public TextMeshProUGUI ammoCount;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void UpdateCurrentInHandUI(ItemInstance item)
    {
        inHandItemImageDisplay.sprite = item.itemSO.image;
        ammoCount.text = item.remainingCharges.ToString();
    }

    public void ReloadFeedback(float duration)
    {
        reloadSlider.maxValue = duration;

        StartCoroutine(ReloadFeedbackFilling(duration));
    }

    IEnumerator ReloadFeedbackFilling(float duration)
    {
        float timePassed = 0;

        while (timePassed < duration)
        {
            yield return new WaitForEndOfFrame();
            timePassed += Time.deltaTime;
            reloadSlider.value = timePassed;
        }

        reloadSlider.value = 0;
    }

    public void RefreshChargesCount(string value)
    {
        ammoCount.text = value;
    }
}
