using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float moveSpeed;

    private CharacterController charController;

    // Start is called before the first frame update
    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }
   
    private void Update()
    {
        PlayerMovement();
    }
   
   private void PlayerMovement()
   {
        float horizontalInput = Input.GetAxis(horizontalInputName);
        float verticalInput = Input.GetAxis(verticalInputName);

        Vector3 forwardMovement = transform.forward * verticalInput;
        Vector3 rightMovement = transform.right * horizontalInput;
        charController.SimpleMove(Vector3.ClampMagnitude(forwardMovement + rightMovement, 1.0f) * moveSpeed);
   }
}
