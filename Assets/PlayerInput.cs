using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private float horizontalSpeed;

    private float move = 0f;
    private bool jump = false;

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw ("Horizontal") * horizontalSpeed;

        if (Input.GetButtonDown ("Jump"))
        {
            jump = true;
            Debug.Log (jump);
        }
    }

    private void FixedUpdate()
    {
        controller.Move (move, jump);
        jump = false;
    }
}
