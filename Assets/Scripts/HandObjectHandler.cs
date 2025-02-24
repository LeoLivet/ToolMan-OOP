using System.Numerics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Vector3 = UnityEngine.Vector3;

public class HandObjectHolder : MonoBehaviour
{
    // Apply a force to a clicked rigidbody object.

    // The force applied to an object when hit.
    float _throwForce = 100;
    [SerializeField] private GameObject _rightHand;
    public bool isRightHandHoldingAnything;
    [SerializeField] private GameObject _heldObject;
    [SerializeField] private Rigidbody _heldObjectRigidbody;
    public int heldObjectThrow;

    UnityEvent _testEvent;
    
    void Start()
    {
        if (_testEvent == null)
        {
            _testEvent = new UnityEvent();
        }
        
        _testEvent.AddListener(null);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isRightHandHoldingAnything)
        {
            DropObject();
        }
        
        if (Input.GetKeyDown(KeyCode.R) && isRightHandHoldingAnything)
        {
            InteractWithObject();
        }
        
        
        if (Input.GetMouseButtonDown(0))
        {
            TryPickupObject();
        }
    }

    private void TryPickupObject()
    {
        if (!isRightHandHoldingAnything)
        {
            PickupObject();
        }
    }

    private void InteractWithObject()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Physics.Raycast(ray, out hit);

        if (TryGetComponent(typeof(Tool), out var tool))
        {
            
        }
            
                // hit.transform.GetComponent<WorkAbleObjects>();
            
            // case 
        
    }
    
    private void PickupObject()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.rigidbody !=null && isRightHandHoldingAnything == false) // TODO fix nesting
            {
                _heldObject = hit.transform.gameObject;
                _heldObjectRigidbody = _heldObject.GetComponent<Rigidbody>();
                    
                // hit.transform.parent = _camera.transform;
                isRightHandHoldingAnything = true;
                _heldObject.transform.SetParent(_rightHand.transform);
                _heldObjectRigidbody.isKinematic= true;
                _heldObject.transform.localPosition = Vector3.zero;
                isRightHandHoldingAnything = true;
                    
                Debug.DrawRay(transform.position, ray.direction, Color.red, 1f);
                // hit.rigidbody.AddForce(ray.direction * _throwForce);
            }
        }
    }
    
    

    public void DropObject()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        Vector3 hitPosition = hit.point;
        _heldObject.transform.position = Vector3.Slerp(_rightHand.transform.position, hitPosition, 10f);
        Debug.Log("E key was pressed. trying to drop the object");
        
        // _heldObject.transform.Translate(Vector3.up * heldObjectThrow);
        // _heldObjectRigidbody.AddForce(_rightHand.transform.forward * _throwForce);
        
        _heldObjectRigidbody.isKinematic = false;
        _heldObjectRigidbody = null;
        _heldObject.transform.SetParent(null);
        isRightHandHoldingAnything = false;
    }
    

    public void RayTester()
    {
        //TODO implement ground tester for dropping slerp.
    }
    
    
}