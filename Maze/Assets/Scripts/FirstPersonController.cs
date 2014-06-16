using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

	public float movementSpeed = 15.0f;
	public float mouseSensitivity = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//Turning
		float sideToSide = Input.GetAxis ( "Mouse X" ) * mouseSensitivity;
		transform.Rotate (0, sideToSide, 0);

		//float upAndDown = Input.GetAxis ( "Mouse Y" ) * mouseSensitivity;
		//Camera.main.transform.Rotate (-upAndDown, 0, 0);

		//Movement
		float forwardSpeed = Input.GetAxis ( "Vertical" ) * movementSpeed;
		float sideSpeed = Input.GetAxis ( "Horizontal" ) * movementSpeed;
		Vector3 speed = new Vector3( sideSpeed, 0 , forwardSpeed );

		speed = transform.rotation * speed ;

		CharacterController cc = GetComponent<CharacterController> ();
		cc.SimpleMove ( speed );

	}
}
