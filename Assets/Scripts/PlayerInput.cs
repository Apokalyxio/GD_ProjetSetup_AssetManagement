using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector3 MovementInputs;
    public Vector3 ViewInputs;

    private static PlayerInput instance;
    public static PlayerInput Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        MovementInputs = new Vector3(Input.GetAxis("Horizontal"), Input.GetKey(KeyCode.Space) ? 1 : 0, Input.GetAxis("Vertical"));
        ViewInputs = Input.mousePosition;
    }
}