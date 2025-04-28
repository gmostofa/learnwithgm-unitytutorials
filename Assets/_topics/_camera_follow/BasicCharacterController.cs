using System;
using UnityEngine;

public class BasicCharacterController : MonoBehaviour
{
  [SerializeField] private CharacterController characterController;
  public float moveSpeed = 5f;


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
  }
}
