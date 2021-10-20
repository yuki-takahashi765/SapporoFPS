using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    [Header("再生するパーティクルの設定")]
    public ParticleSystem effect;
    public int HP = 2;
    void OnCollisionEnter(Collision obj)
    {
        if (obj.transform.name == "EnemyShot(Clone)")
        //　「""」の中はどのオブジェクトと衝突するか
        {
            effect.Play();//エフェクトに設定されていたものを再生
            //Debug.Log("hit");//デバッグ用。当たったときにコンソールにhitが出ていたらここまで通ってる
            Destroy(obj.gameObject);

            if (HP > 0) 
            {
                HP--;
                Debug.Log(HP);
                if (HP == 0)
                {
                    Debug.Log("Gameover");
                }

            }
        }
    }
}
