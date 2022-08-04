using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public Transform carTransform;
	
	void FixedUpdate () {


        transform.position = new Vector2(carTransform.position.x, carTransform.position.y);

        var thing = transform.position;

        thing.z = -10;

        transform.position = thing;
    }
}
