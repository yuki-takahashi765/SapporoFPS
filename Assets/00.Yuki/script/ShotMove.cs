using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMove : MonoBehaviour
{
    [Header("x：横,y：高さ,z：奥行き")]
    [Header("射出速度/向き設定")]
    public float x;
    public float y;
    public float z=2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(x, y, z);
    }
}
