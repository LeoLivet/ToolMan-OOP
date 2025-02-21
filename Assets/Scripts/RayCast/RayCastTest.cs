using UnityEngine;
using UnityEngine.Serialization;

public class RayCastTest : MonoBehaviour
{
    // Apply a force to a clicked rigidbody object.

    // The force applied to an object when hit.
    float hitForce = 100;
    [SerializeField] private GameObject _rightHand;
    public bool isRightHandHoldingAnything;
    [SerializeField] private GameObject _heldObject;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isRightHandHoldingAnything)
        {
            Debug.Log("E key was pressed. trying to drop the object");
            _heldObject.transform.SetParent(null);
            _heldObject.GetComponent<Rigidbody>().isKinematic = false;
            _heldObject.GetComponent<Rigidbody>().AddForce(_rightHand.transform.forward * hitForce);
            isRightHandHoldingAnything = false;
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody !=null && isRightHandHoldingAnything == false)
                {
                    _heldObject = hit.transform.gameObject;
                    // hit.transform.parent = _camera.transform;
                    isRightHandHoldingAnything = true;
                    _heldObject.transform.SetParent(_rightHand.transform);
                    _heldObject.GetComponent<Rigidbody>().isKinematic= true;
                    _heldObject.transform.localPosition = Vector3.zero;
                    isRightHandHoldingAnything = true;
                    
                    Debug.DrawRay(transform.position, ray.direction, Color.red, 1f);
                    // hit.rigidbody.AddForce(ray.direction * hitForce);
                }
            }
        }
    }
}