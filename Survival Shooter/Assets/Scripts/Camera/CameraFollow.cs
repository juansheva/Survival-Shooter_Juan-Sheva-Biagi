using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    private Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        //Mendapatkan offset antara target dan camera
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void FixedUpdate()
    {
        //Menapatkan posisi untuk camera
        Vector3 targetCamPos = target.position + offset;

        //set posisi camera dengan smoothing
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}