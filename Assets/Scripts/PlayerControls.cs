using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    private InputAction _moveAction;
    private InputAction _jumpAction;
    [SerializeField] CharacterController controller;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;
    private Rigidbody _rigidbody;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _moveAction = InputSystem.actions.FindAction("Move");
        _jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveValue = _moveAction.ReadValue<Vector2>();
        
        if(_moveAction.IsPressed())
        {
            transform.Translate(new Vector3(moveValue.x, 0, moveValue.y) * (moveSpeed * Time.deltaTime));
        }
        
        if (_jumpAction.IsPressed())
        {
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
        }
        
    }
}
