using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHit : MonoBehaviour
{
    [Header("HPのUIテキストをD＆D")]
    public Text hitPointText;

    [Header("再生するパーティクルの設定")]
    public ParticleSystem effect;
    public int HP = 2;
    [Header("HP0のときに削除する自キャラを追加")]
    public GameObject TestUnityChan;

    public float runningSpeed { get; private set; }

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
                    Debug.Log("操作OFF後");
                    Destroy(this.GetComponent<vThirdPersonInput>());
                    List<KeyCode> disabledKeys = new List<KeyCode>();
                    Destroy(this.GetComponent<vThirdPersonMotor>());
                    Destroy(TestUnityChan);
                }
            }

            string str = hitPointText.text;
            string str1 = str.Substring(0, str.IndexOf(":") + 1);
            Debug.Log(str1);
            string str2 = str.Substring(str.IndexOf(":") + 1);
            Debug.Log(str2);
            str2 =HP.ToString();
            hitPointText.text = str1 + str2;

        }
    }

    void Update()
    {
 
    }
}
