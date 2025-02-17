using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    [Header("Basics Info")]
    private Vector3 _translation;
    private Vector3 _rotation;
    public float Speed;

    Vector3 desiredForward;

    // Start is called before the first frame update
    void Start()
    {
        desiredForward = transform.forward;
    }

    // Update is called once per frame

    void Update()
    {
        _translation.x = Input.GetAxisRaw("Horizontal");
        _translation.z = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        transform.Translate(_translation * Speed * Time.deltaTime, Space.World);

        float angleInDegrees = Mathf.Atan2(_translation.z, _translation.x) * Mathf.Rad2Deg;

        Debug.Log(angleInDegrees);
        //Quaternion turn = Quaternion.AngleAxis(r, Vector3.up);
        //desiredForward = turn * desiredForward;

        transform.Rotate(new Vector3(0,angleInDegrees,0) * Speed * Time.deltaTime);


        //float r = Vector3.Angle(transform.forward, _translation);
        //DriveRotation(desiredForward, Vector3.up);

        //Quaternion a = transform.rotation;
        //float r = Vector3.Angle(transform.forward, _translation);
        //Quaternion b = Quaternion.Euler(0,r,0);
        //Quaternion s = Quaternion.Slerp(a, b, Speed);
        //transform.localRotation = s;

        //transform.Rotate(_translation * Speed * Time.deltaTime, Space.World);
    }
    void DriveRotation(Vector3 currentForward, Vector3 currentUp)
    {
        Quaternion rotation = Quaternion.LookRotation(currentForward, currentUp);

        transform.rotation = rotation;
    }
}
