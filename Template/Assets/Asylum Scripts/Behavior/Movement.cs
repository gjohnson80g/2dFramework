using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float moveSpeed;
	public float jumpHeight;
	private bool isJumping = false;
	private bool grounded = true;
	public bool flying = false;
	public bool isAI = false;
	public float orbitDistance;
	public float activeDistance = 100.0f;
	public GameObject movingObject;
	
	
	private float lastPos;
	private float currPos;

	// Use this for initialization
	void Start () {
	
	}
	
	
	void OnCollisionEnter(Collision collision)
	{
			if(collision.gameObject.tag == "ground")
			{
				grounded = true;
				
			}
			//TODO - this exists for cuberunner only
			if(collision.gameObject.name == "win-platform")
			{
				Application.LoadLevel("WinMenu");
				
			}
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.eulerAngles = new Vector3(transform.eulerAngles.x,0 ,transform.eulerAngles.z);
        transform.position = new Vector3(transform.position.x,transform.position.y,0);
    
		
		
		if(!isAI)
		{
			//TODO - Refactor
			if(grounded)
			{
				float move = Input.GetAxis("Horizontal") * (moveSpeed / 10);
				transform.Translate(-move, 0, 0);
			}
			else
			{
				float move = Input.GetAxis("Horizontal") * (moveSpeed / 20);
				transform.Translate(-move, 0, 0);
			}
			
		
		
			if(Input.GetButtonDown("Jump"))
			{
				if(grounded )
				{
					
					//transform.Translate(0, jumpHeight, 0);
					rigidbody.AddForce(Vector3.up * jumpHeight * 10);
					grounded = false;
					
					
				}
		
			}
		}
		else
		{
			//get distance between this and player
			//if within activeDistance move toward player 
			//until within orbitDistance then maintain that distance (x-axis)
			//else do nothing
			
			float distance = Vector3.Distance(GameObject.Find("mover").transform.position, movingObject.transform.position);
			
			
			if (distance < activeDistance)
			{
					if(distance > orbitDistance)
					{
							transform.Translate(moveSpeed / 10, 0, 0);
					}
					else if(distance < orbitDistance)
					{
							transform.Translate(-moveSpeed / 10, 0, 0);
					}
			}

			
		}
	}
		
		
	void LateUpdate()
	{
		
	}
	
	
}


