using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(LineRenderer))]
public class Laser : MonoBehaviour {

    public LineRenderer Lr;

    // Use this for initialization
    void Start () {
        Lr = GetComponent<LineRenderer>();

    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                Lr.SetPosition(1, new Vector3(0,0,hit.distance * 2.5f));
            }
            else
            {
                Lr.SetPosition(1, new Vector3(0, 0, 5000));
            }
        }

    }
}
