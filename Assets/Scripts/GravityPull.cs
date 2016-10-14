using UnityEngine;
using System.Collections;

public class GravityPull : MonoBehaviour {

    public GameObject o;

    void FixedUpdate()
    {
        Vector3 diff = o.transform.position - transform.position;
        diff.Normalize();
        o.transform.position -= diff * .04f;
    }
}

