using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_house : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        other.transform.SetPositionAndRotation(new Vector3(292, 12, -193), new Quaternion(0, 0, 0, 0));
    }
}
