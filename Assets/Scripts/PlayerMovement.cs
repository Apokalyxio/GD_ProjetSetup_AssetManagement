using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 10f;
    public Transform CameraAncor;

    private Rigidbody rb;
    private Vector3 MovementForce;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        MovementForce = PlayerInput.Instance.MovementInputs;
    }

    private void FixedUpdate()
    {
        rb.AddRelativeForce(MovementForce * MovementSpeed);
        this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, PlayerInput.Instance.ViewInputs.x, this.transform.rotation.z);
        CameraAncor.localRotation = Quaternion.Euler(-PlayerInput.Instance.ViewInputs.y, CameraAncor.rotation.y, CameraAncor.rotation.z);
    }
}
