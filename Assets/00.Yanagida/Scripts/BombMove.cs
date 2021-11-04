using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMove : MonoBehaviour
{
    [Header("x�F��,y�F����,z�F���s��")]
    [Header("�ˏo���x/�����ݒ�")]
    public float x;
    public float y;
    public float z=0.00001f;

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