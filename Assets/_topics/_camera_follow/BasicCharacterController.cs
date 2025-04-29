using System;
using UnityEngine;

public class BasicCharacterController : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    public float moveSpeed = 5f;
    
    public Vector3 velocity;
    public float gravity = -9.81f;
    public float jumpHeight = 2f;

    private void Start()
    {
      characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
      float horizontal = Input.GetAxis("Horizontal");
      float vertical = Input.GetAxis("Vertical");
      
      Vector3 moveDirection = transform.forward * vertical + transform.right * horizontal;
      characterController.Move(moveDirection * (moveSpeed * Time.deltaTime));

      if (characterController.isGrounded && velocity.y < 0)
      {
          velocity.y = -2f;
      }
      
      velocity.y += gravity * Time.deltaTime;
      characterController.Move(velocity * Time.deltaTime);

      if (Input.GetButtonDown("Jump") && characterController.isGrounded)
      {
          velocity.y = Mathf.Sqrt(2 * gravity * jumpHeight * -1);
      } 
    }
}
