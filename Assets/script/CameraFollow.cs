using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField] GameObject target;
    Vector2 pos;
	// Use this for initialization
    private void LateUpadate()
    {
        pos = target.transform.position;
        this.transform.position = new Vector3(pos.x, pos.y, this.transform.position.z);
    } 
}
