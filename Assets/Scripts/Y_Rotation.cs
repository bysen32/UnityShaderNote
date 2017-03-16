using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y_Rotation : MonoBehaviour {
    public float speed = 3;
    void FixedUpdate() {
        transform.Rotate(new Vector3(0, speed, 0));
    }
}
