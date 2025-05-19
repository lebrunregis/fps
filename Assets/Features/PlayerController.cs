using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public Transform eyeTransform;
    public float moveSpeed;
    public CharacterController controller;
    public Vector2 input;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
       Vector3 move=  moveSpeed* input;
       controller.SimpleMove(new Vector3(move.x, move.z, move.y));
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        input = ctx.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        controller.SimpleMove(new Vector3(0, 0, 0));
    }

    public void OnLook(InputAction.CallbackContext ctx)
    {

    }
}
