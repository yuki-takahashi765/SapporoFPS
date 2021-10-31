using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRepop : MonoBehaviour
{
    [Header("復活させるエネミー")]
    public GameObject prefab;

    [Header("リスポンするまでの間隔時間")]
    public float repopTime;


    private float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        EnemyMove EnemyMove = prefab.GetComponent<EnemyMove>();     
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= repopTime)
        {
            timeElapsed = 0;
            prefab.SetActive(true);

        }
 
    }

}
