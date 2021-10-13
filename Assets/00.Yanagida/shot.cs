using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // ‘O•û‚É”­ŽË
            var pos = transform.position + transform.forward * 2 + transform.up * 1;
            Instantiate(prefab, pos, transform.rotation);
        }

    }
}
