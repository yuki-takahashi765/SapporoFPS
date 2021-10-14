using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public ParticleSystem effect;//インスペクター上にエフェクト設定が行える用
    private float timeElapsed;
    public float X=-0.05f;
    public float Y=0f;
    public float Z = 0;
    public float X2= 0.05f;
    public float Y2= 0.15f;
    public float Z2=0;


    // Update is called once per frame
    void Update()
    {

        timeElapsed += Time.deltaTime;

        if (timeElapsed <= 1)
        {
            transform.Translate(X, Y, Z);
            return;
        }
        else if (timeElapsed <= 2)
        {
            return;
        }
        else if (timeElapsed <= 3)
        {
            transform.Translate(X2, Y2, Z2);
            return;
        }
        else if (timeElapsed <= 4)
        {
            return;
        }
        timeElapsed = 0;

    }

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