using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>Sets player's speed</summary>
    public float speed = 2.0f;
    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0);
        controller.Move(move * Time.deltaTime * speed);

        if (move != Vector3.zero)
            gameObject.transform.forward = move;
    }
}
