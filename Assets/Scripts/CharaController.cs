using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    [Header("Basics Info")]
    private Vector3 _translation;
    public float Speed;
    public float SpeedRotation;

    private Quaternion targetRotation;

    void Update()
    {
        _translation.x = Input.GetAxisRaw("Horizontal");
        _translation.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (_translation != Vector3.zero)
        {
            transform.Translate(_translation * Speed * Time.deltaTime, Space.World);

            targetRotation = Quaternion.LookRotation(_translation);
            float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, targetRotation.eulerAngles.y, SpeedRotation * Time.deltaTime);
            transform.eulerAngles = Vector3.up * angle;
        }
    }
}
