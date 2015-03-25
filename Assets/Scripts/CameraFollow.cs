using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public bool X, Y, Z;

    public float XOffset, YOffset, ZOffset;

	void Update () {
        transform.position = new Vector3 (
            (X ? target.position.x + XOffset : transform.position.x),
            (Y ? target.position.y + YOffset : transform.position.y),
            (Z ? target.position.z + ZOffset : transform.position.z));
        //Use of conditional operator
	}
}
