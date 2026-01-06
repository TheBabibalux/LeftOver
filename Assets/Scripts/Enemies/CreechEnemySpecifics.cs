using System.Collections;
using UnityEngine;

public class CreechEnemySpecifics : MonoBehaviour
{
    public TargetHitZone[] weakPointList;
    public Vector2 targetOpeningDuration;
    public Vector2 targetOpeningDelayDuration;

    [SerializeField] float nextTargetOpening = 0;
    [SerializeField] float actualOpeningTime = 0;

    void Start()
    {
        foreach (var weakPoint in weakPointList)
        {
            weakPoint.SetTargetHitZone(false);
            weakPoint.SetWeakPointVisual(false);
        }

        nextTargetOpening = Random.Range(targetOpeningDelayDuration.x, targetOpeningDelayDuration.y);
    }

    private void FixedUpdate()
    {
        actualOpeningTime += Time.deltaTime;

        if(actualOpeningTime > nextTargetOpening)
        {
            OpenTarget(Random.Range((int)0,(int)weakPointList.Length-1));

            actualOpeningTime = 0;
            nextTargetOpening = Random.Range(targetOpeningDelayDuration.x, targetOpeningDelayDuration.y);
        }
    }

    void OpenTarget(int id)
    {
        weakPointList[id].SetTargetHitZone(true);
        weakPointList[id].SetWeakPointVisual(true);

        StartCoroutine(OpenTime(id));
    }

    IEnumerator OpenTime(int id)
    {
        yield return new WaitForSeconds(Random.Range(targetOpeningDuration.x, targetOpeningDuration.y));
        CloseTarget(id);
    }

    void CloseTarget(int id)
    {
        weakPointList[id].SetTargetHitZone(false);

        weakPointList[id].SetWeakPointVisual(false);
    }

}
