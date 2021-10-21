using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class down : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 m_YAxis;
    float m_Speed;

    void Start()
    {
        //リジットボディを取得
        m_Rigidbody = GetComponent<Rigidbody>();
        //m_Rigidbody.constraints = RigidbodyConstraints.None;
       //* m_YAxis = new Vector3(0, 5, 0);
        //m_Speed = 20.0f;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C)) //Cを押し続けているとき
        {
            //トランスフォームの位置を取得
            Vector3 pos = gameObject.transform.position;
            //下げたい値を入力
            pos.y += -0.7f;
            //値を位置に返す
            gameObject.transform.position = pos;
            //リジットボディの位置・回転を固定
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
        if (Input.GetKeyUp(KeyCode.C))　//Cを離したとき
        {
            //トランスフォームの位置を取得
            Vector3 pos = gameObject.transform.position;
            //上の値のマイナスを取る
            pos.y += 0.7f;
            //値を位置に返す
            gameObject.transform.position = pos;
            //リジットボディの位置・回転の固定を解除
            m_Rigidbody.constraints = RigidbodyConstraints.None;
            //リジットボディの回転を固定
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }

}
