using UnityEngine;
using System.Collections;

public class IsometricCharacterController : MonoBehaviour {

    public float walkSpeed = 4f;

    Vector3 forward, right;
    private float moveSpeed;
    public SpriteRenderer karl;

	
	void Start () {

        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);

      
        right = Quaternion.Euler(new Vector3(0,90,0)) * forward;

     
        moveSpeed = walkSpeed;
	    
	}
	
	
	void Update () {

       if (Input.GetKey(KeyCode.A))
        {
            //gameObject.transform.localScale = new Vector2(-1, 1);
            karl.flipX = true;

        }
        if (Input.GetKey(KeyCode.D))
        {
            //gameObject.transform.localScale = new Vector2(1, 1);
            karl.flipX = false;
        }








        if (Input.anyKey) {
            Move();
        }

	}

    void Move() {

        Vector3 rightMovement = right * moveSpeed * Input.GetAxis("Horizontal");
        Vector3 upMovement = forward * moveSpeed * Input.GetAxis("Vertical");
    
        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        
        Vector3 newPosition = transform.position;
        newPosition += rightMovement;
        newPosition += upMovement;

       
        transform.forward = heading;
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);

    }
}
