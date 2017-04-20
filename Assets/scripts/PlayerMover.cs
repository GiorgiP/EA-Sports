using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

    Vector3 deltaPos;

    public float speedMultiplier;
    //public Transform player;
    public Rigidbody playerBody;

	void Start () {

        deltaPos = Vector3.zero;
		
	}
	
	
	void Update () {

        deltaPos.z = Input.GetAxis("Vertical");  //gadaadgileba z gerdze
        deltaPos.x = Input.GetAxis("Horizontal"); //gadaadgileba x gerdze

        //playerBody.position = playerBody.position + deltaPos; //modzraobis kodi

        // Input.GetAxis("Horizontal");

        //player.position += deltaPos;

        //transform.position =+ deltaPos;

	}
    private void FixedUpdate()
    {
        // playerBody.position = playerBody.position + deltaPos;

        playerBody.AddForce(deltaPos *speedMultiplier);


    }

}
