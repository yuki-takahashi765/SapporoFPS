using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{

    public GameObject prefab;
    private float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

        

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ‘O•û‚É”­ŽË
            var pos = transform.position + transform.forward * 2 + transform.up * 1;
            var del =Instantiate(prefab, pos, transform.rotation);

            Destroy(del, 1.0f);
        }
        

    }
}
