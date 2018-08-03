using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float MoveSpeed = 10f;
    public float WalkSpeed = 10f;
    public float SprintSpeed = 8.0f;
    public float jumpForce;
    public CharacterController controller;
    public float gravityScale;

    public CameraFollow CamFollow;

    public float TurnSpeed;
    public float GunTurnSpeed;
    Quaternion _targetROT;

    Rigidbody rb;

    public bool OnPlatform;

    //public Transform playerRotation;


    private Vector3 moveDirection;

    public Transform IceGunTransform;




	// Use this for initialization
	void Start () {

        controller = GetComponent<CharacterController>();

        MoveSpeed = WalkSpeed;
	}

    // Update is called once per frame
    void Update () {


        



        if (Input.GetKey(KeyCode.LeftShift))
        {
            MoveSpeed = SprintSpeed;
            CamFollow.Sprinting = true;

        }
        else
        {
            MoveSpeed = WalkSpeed;
            CamFollow.Sprinting = false;
        }
        //gameObject.transform.position += transform * MoveSpeed * Time.deltaTime;




        //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);


        //playerRotation = GetComponent<>();


        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);


        //Player move in direction of camera//
        float yStore = moveDirection.y;
        moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        moveDirection = moveDirection.normalized * MoveSpeed;
        moveDirection.y = yStore;
        //Player move in direction of camera//

        if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0){
            if (OnPlatform)
            {
                //transform.SetParent(null);
                //Debug.Log("Vertical and horizontal are equal to zero my parent = " + transform.parent);
            }
        }

        if(OnPlatform == false && transform.parent != null)
        {
            transform.SetParent(null);
        }


        if (controller.isGrounded)
        {
            moveDirection.y = 0f;
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
                //controller.Move(-controller.velocity);
            }
        }

        //Gravity
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        //Gravity

        //Character camera rotation
        if(moveDirection.x != 0 || moveDirection.z != 0)
        {
            _targetROT = Quaternion.Euler(transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, _targetROT, Time.deltaTime * TurnSpeed);
        ///Character camera rotation

        //Gun Rotation
        Quaternion _targetROTGun = Quaternion.Euler(Camera.main.transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, IceGunTransform.rotation.eulerAngles.z);
        IceGunTransform.rotation = Quaternion.Slerp(IceGunTransform.rotation, _targetROTGun, Time.deltaTime * GunTurnSpeed);
        //Gun Rotation





        controller.Move(moveDirection * Time.deltaTime);

		
	}

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("Player Hit tRIGGER Something. Tag = " + col.tag);
        if (col.gameObject.tag == "Platform")
        {
            OnPlatform = true;
            transform.SetParent(col.gameObject.transform);
            Debug.Log("Triggered Platform my parent = " + transform.parent);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Platform")
        {
            OnPlatform = true;
        }
        else
        {
            OnPlatform = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Platform")
        {
            OnPlatform = false;
        }
    }

    //Player colliding wiht box
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            rb.isKinematic = false;
            Destroy(col.gameObject);

            Debug.Log("Hit object and it's tag is player");
            Debug.Log("Player Hit Something");
        }

    }

    /*private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Player Hit Something");

  
    }*/

}
