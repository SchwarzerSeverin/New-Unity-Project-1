using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_win : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {

        other.transform.SetPositionAndRotation(new Vector3(269, 2, 142), new Quaternion(0, 0, 0, 0));
    }
}
