using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>Sets player's speed</summary>
    public float speed = 5.0f;
    private CharacterController controller;
    private int score = 0;

    ///<summary>Adds an instance of CharacterController to Player at start</summary>
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    ///<summary>Moves game object when keys WASD or arrow keys are pressed</summary>
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);
    }

    ///<summary>Inriments score when Player touches object called Pickup</summary>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Pickup")
        {
            score += 1;
            Debug.Log($"Score: {score}");
            Destroy(other.gameObject);
        }
    }

    /// <summary>Destroys controller on disable</summary>
    public void OnDisable()
    {
        Destroy(controller);
    }
}
