using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityStandardAssets.Utility;

public class FootMove : MonoBehaviourPunCallbacks
{
    Vector3 lookDirection;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.A))
            {
                float x = Input.GetAxisRaw("Vertical");
                float z = Input.GetAxisRaw("Horizontal");
                lookDirection = x * Vector3.forward + z * Vector3.right;

                this.transform.rotation = Quaternion.LookRotation(lookDirection);
            }
        }
    }
}
