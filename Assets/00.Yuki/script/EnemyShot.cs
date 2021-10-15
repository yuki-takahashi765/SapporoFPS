using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{

    public GameObject enemyShotPrefab;
    
    [Header("自動で射出するまでの時間")]
    public float shotInterval=1.0f;
    float timeCount;

 
    // Update is called once per frame
    void Update()
    {
        //時間計測
        timeCount += Time.deltaTime;
        //指定の秒数以上になった場合
        if (timeCount >= shotInterval)
        {
            //カウントをリセット
            timeCount = 0;
            //弾を生成
            var pos = transform.position + transform.forward * 2 + transform.up * 1;
            Instantiate(enemyShotPrefab, pos, transform.rotation);
           // Instantiate(enemyShotPrefab, transform.position, Quaternion.identity);
        }
    }
}
