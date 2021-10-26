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
    [Header("HP0のときに削除する自キャラとカメラを追加")]
    public GameObject playerPrefab;
    public GameObject deleteCamera;

    [Header("HP0のときに追加するカメラ")]
    public GameObject addCamera;


    void OnCollisionEnter(Collision obj)
    {
        if (obj.transform.name == "EnemyShot(Clone)")
        //　「""」の中はどのオブジェクトと衝突するか
        {
            effect.Play();//エフェクトに設定されていたものを再生
            Destroy(obj.gameObject);

            if (HP > 0)
            {
                HP--;
                //Debug.Log(HP);
                if (HP == 0)
                {

                    hitPointText.text = "       GameOver";
                    Debug.Log("操作OFF後");
                    Destroy(playerPrefab);
                    Destroy(deleteCamera);

                    var pos = transform.position + transform.forward + transform.up;
                    var del = Instantiate(addCamera, pos, transform.rotation);
                }
                else
                {
                    string str = hitPointText.text;
                    string str1 = str.Substring(0, str.IndexOf(":") + 1);
                    string str2 = HP.ToString();
                    hitPointText.text = str1 + str2;
                }
            }
        }
    }

    void Start()
    {
        string str = hitPointText.text;
        string str1 = str.Substring(0, str.IndexOf(":") + 1);
        string str2 = HP.ToString();
        hitPointText.text = str1 + str2;
    }
}
