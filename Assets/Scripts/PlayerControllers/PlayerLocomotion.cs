using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    private CharacterController Controller;
    private Vector3 playerVelocity;
    public float Speed;

    private bool groundedPlayer;

    private void Start()
    {
        Controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = Controller.isGrounded;
        
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Controller.Move(move * Time.deltaTime * Speed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
}