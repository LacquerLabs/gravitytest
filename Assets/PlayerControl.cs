using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    private Rigidbody theRigidbody;
    public Vector3 moveDirection;

    public float speed = 10.0f;

    void Awake() {
        theRigidbody = GetComponent<Rigidbody>();
    }

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;		
    }

    void Update() {
        if (Input.GetKeyDown("escape")) {
            Cursor.lockState = CursorLockMode.None;
        }

        float verticalMovement = 0f;
        
        if (Input.GetKeyDown("space")) {
            verticalMovement = + 0.5f;
        }

        if (Input.GetKeyDown("c")) {
            verticalMovement = - 0.5f;
        }

        float sideMovement = Input.GetAxisRaw("Horizontal");
        float forwardMovement = Input.GetAxisRaw("Vertical");
        moveDirection = (sideMovement * transform.right + forwardMovement * transform.forward + verticalMovement * transform.up).normalized;
    }

    void FixedUpdate() {
        theRigidbody.velocity += moveDirection * speed * Time.deltaTime;
    }
}