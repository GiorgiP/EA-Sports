
using UnityEngine;

public class CameFollower : MonoBehaviour {


    public Transform target;
    private Vector3 distanceFromTarget;



	void Start () {

        distanceFromTarget = transform.position - target.position;
		
	}
	
	
	void Update () {

        transform.position = target.position + distanceFromTarget;

		
	}
}
