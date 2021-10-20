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
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.None;
        //Set up vector for moving the Rigidbody in the y axis
        m_YAxis = new Vector3(0, 5, 0);
        m_Speed = 20.0f;
    }

    void Update()
    {

        //Press space to add constraints on the RigidBody (freeze all rotations)
        if (Input.GetKeyDown(KeyCode.C))
        {
            Vector3 pos = gameObject.transform.position;

            pos.y += -0.7f;

            gameObject.transform.position = pos;
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Vector3 pos = gameObject.transform.position;

           
            pos.y += 0.7f;

            gameObject.transform.position = pos;
            m_Rigidbody.constraints = RigidbodyConstraints.None;
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }

}
