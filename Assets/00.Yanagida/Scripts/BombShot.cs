using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombShot : MonoBehaviour
{
public GameObject grenadePrefab;
    public AudioClip throwSound;
    public float throwSpeed;
    public int grenadeCount;
    public Text bombText;
   

	void Update () {
        if(Input.GetKeyDown(KeyCode.Mouse1) && grenadeCount > 0){
            grenadeCount -= 1;

            GameObject grenade = (GameObject)Instantiate(grenadePrefab, transform.position, Quaternion.identity);
            Rigidbody grenadeRb = grenade.GetComponent<Rigidbody>();
            grenadeRb.AddForce(transform.forward * throwSpeed);
            AudioSource.PlayClipAtPoint(throwSound, Camera.main.transform.position);
            
        }
        string str = bombText.text;
        string str1 = str.Substring(0, str.IndexOf(":") + 1);
        string str2 = str.Substring(str.IndexOf(":") + 1);
        str2 = grenadeCount.ToString();
        bombText.text = str1 + str2;
	}
}
