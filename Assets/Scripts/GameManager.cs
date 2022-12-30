using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab; //置放Prefab的公開變數
    public GameObject catfoodPrefab;

    public GameObject hpGauge;

    void Start()
    {
        InvokeRepeating("MakeArrow", 0, 1.0f);
        InvokeRepeating("MakeCatfood", 0, 1.0f);
    }


    void MakeArrow()
    {
        int px = Random.Range(-6, 7); // 隨機產生一個-6到6之間的整數
        // 產生新箭頭，並且設定新箭頭的位置
        Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity);
    }
    void MakeCatfood()
    {
        int px = Random.Range(-6, 7); // 隨機產生一個-6到6之間的整數
        // 產生新箭頭，並且設定新箭頭的位置
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
