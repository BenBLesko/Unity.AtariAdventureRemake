using UnityEngine;

public class AltPlayerLocomotion : MonoBehaviour
{
    CharacterController characterController;

    public float Speed;
    public float Gravity;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= Speed;
        }

        moveDirection.y -= Gravity * Time.deltaTime;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
