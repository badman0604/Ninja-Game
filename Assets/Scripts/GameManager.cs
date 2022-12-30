using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab; //�m��Prefab�����}�ܼ�
    public GameObject catfoodPrefab;

    public GameObject hpGauge;

    void Start()
    {
        InvokeRepeating("MakeArrow", 0, 1.0f);
        InvokeRepeating("MakeCatfood", 0, 1.0f);
    }


    void MakeArrow()
    {
        int px = Random.Range(-6, 7); // �H�����ͤ@��-6��6���������
        // ���ͷs�b�Y�A�åB�]�w�s�b�Y����m
        Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity);
    }
    void MakeCatfood()
    {
        int px = Random.Range(-6, 7); // �H�����ͤ@��-6��6���������
        // ���ͷs�b�Y�A�åB�]�w�s�b�Y����m
        Instantiate(catfoodPrefab, new Vector3(px, 7, 0), Quaternion.identity);
    }
    public void IncreaseHP()
    {
        hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }


    public void DecreaseHP()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
