using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slerp : MonoBehaviour {
    public Transform startPos;
    public Transform endPos;
    public float journeyTime = 1f;
    public float speed;
    public bool repeatable;
    public float EndPointOffsetMax;
    

    float startTime;
    Vector3 centerPoint;
    Vector3 startRelCenter;//start realivent center
    Vector3 endRelCenter;//end realivent center

    private void Start()
    {
        endPos.SetParent(null);
    }

    void Update()
    {
        GetCenter(Vector3.up);
        if (!repeatable)
        {
            float fracComplete = (Time.time - startTime) / journeyTime * speed;
            transform.position = Vector3.Slerp(startRelCenter, endRelCenter, fracComplete * speed);
            transform.position += centerPoint;
        }



    }
    public void GetCenter(Vector3 direction)
    {
        centerPoint = (startPos.position + endPos.position) * 0.5f;


        centerPoint -= direction;
        //centerPoint -= new Vector3(0, 10, 8);//Put Ray cast hit position here

        startRelCenter = startPos.position - centerPoint;

        endRelCenter = (endPos.position - centerPoint);
    }
}
