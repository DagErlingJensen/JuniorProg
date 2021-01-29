using Bolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float upForce;
    public float gravityModifier;

    public float maxHeight;
    public float minHeight;

    private Rigidbody rbPlayer;

    
    
    void Start()
    {
        rbPlayer = gameObject.GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }

        void Update()
    {
         if (Input.GetKey(KeyCode.Space))
            {
                rbPlayer.AddForce(Vector3.up * upForce, ForceMode.Force);
            }
    }
 }

