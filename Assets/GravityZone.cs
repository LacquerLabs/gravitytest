using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityZone : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        Transform thething =  other.GetComponent<Collider>().transform.parent;
        Debug.Log( thething.name + " collided with me" );
        if (other.attachedRigidbody) {
            other.attachedRigidbody.useGravity = true;
            thething.SetParent(this.transform.root);
        }
    }
    private void OnTriggerExit(Collider other) {
        Transform thething =  other.GetComponent<Collider>().transform.parent;
        Debug.Log( thething.name + " exited me" );
        if (other.attachedRigidbody) {
            other.attachedRigidbody.useGravity = false;
            thething.SetParent(null);
        }
    }
}
