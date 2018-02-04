using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {

        other.transform.SetPositionAndRotation(new Vector3(326, 3, -36), new Quaternion(0, 0, 0, 0));
    }
}
