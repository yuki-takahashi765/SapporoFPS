using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public ParticleSystem effect;//インスペクター上にエフェクト設定が行える用
    void OnCollisionEnter(Collision obj)
    {
        if (obj.transform.name == "ShotCube(Clone)")
        //　「""」の中はどのオブジェクトと衝突するか
        //　このソースはShotCubeという弾を打った時に生成されている「ShotCube(Clone)」で設定
        {
            effect.Play();//エフェクトに設定されていたものを再生
            Debug.Log("hit");//デバッグ用。当たったときにコンソールにhitが出ていたらここまで通ってる
        }
    }
}