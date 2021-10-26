using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shot : MonoBehaviour
{
    public GameObject prefab;
    private float timeElapsed;
    public int shotCount = 10; //弾の数
    private float shotInterval;
    public Text shotText;
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
           shotInterval += 1;
            Debug.Log("shotInterval"+shotInterval);//コンソールに出るように髙橋追加
            Debug.Log("shotCount"+shotCount);//コンソールに出るように髙橋追加
            if (shotInterval % 5 == 0 && shotCount > 0)　//shotCountが0になるまで発射動作する
            {
                shotCount -= 1;

                // 前方に発射
                 var pos = transform.position + transform.forward * 2 + transform.up * 1;
                var del = Instantiate(prefab, pos, transform.rotation);

               

                   
                
                    Destroy(del, 1.0f);
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))　//shotCountが0になった時、Rキーでリロードする
        {
            shotCount = 10;//ここ10弾固定になっちゃうからもう一つ変数用意して同値代入出来るようにしたほうが楽かも

        }
        string str = shotText.text;
        string str1 = str.Substring(0, str.IndexOf(":") + 1);
        string str2 = str.Substring(str.IndexOf(":") + 1);
        str2 = shotCount.ToString();
        shotText.text = str1 + str2;
        

    }
}
