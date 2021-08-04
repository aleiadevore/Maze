using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>Sets player's speed</summary>
    public float speed = 10.0f;
    ///<summary>Set's Players health (default of 5)</summary>
    public int health = 5;
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

    ///<summary>Inriments score when Player touches object called "Pickup," decriments health when player touches object tagged "Trap." Handles win.</summary>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Pickup")
        {
            score += 1;
            Debug.Log($"Score: {score}");
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag=="Trap")
        {
            health -= 1;
            Debug.Log($"Health: {health}");
        }

        if (other.gameObject.tag=="Goal")
        {
            Debug.Log("You win!");
        }
    }

    /// <summary>Destroys controller on disable</summary>
    public void OnDisable()
    {
        Destroy(controller);
    }
}
