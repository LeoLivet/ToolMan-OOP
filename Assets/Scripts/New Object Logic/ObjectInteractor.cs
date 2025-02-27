using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace New_Object_Logic
{
    public class ObjectInteractor : MonoBehaviour
    {
        [Header("Raycast Settings")]
        [SerializeField] private float raycastDistance = 5f;
    
        [Header("Raycast Settings")]
        // [SerializeField] private ToolCode  toolCode;
        [SerializeField] private Image _crosshair;
    
    
        [SerializeField]private Camera _camera;
        private ObjectItem objectItem;
        private InputAction _interactAction; 
    
        void Start()
        {
            _camera = GetComponentInChildren<Camera>();
            _interactAction = InputSystem.actions.FindAction("Interact");
        }

        private void Update()
        {
            PerformRaycast();

            InteractionInput();
        }

        void InteractionInput()
        {
            if (objectItem != null)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    objectItem.ObjectInteraction();
                    Debug.Log("Attempt Interacting with object");
                }
            }
        }

        void PerformRaycast()
        {
            if (Physics.Raycast(_camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f)), transform.forward, out RaycastHit hit, raycastDistance))
            {
                var _objectItem = hit.collider.GetComponent<ObjectItem>();
                if (_objectItem != null)
                {
                    objectItem = _objectItem;
                    HighlightCrosshair(true);
                    // Debug.Log($"Looking at{objectItem.name} ");
                }
                else
                {
                    ClearItem();
                }
            }
            else
            {
                ClearItem();
            }
        }

        void ClearItem()
        {
            if (objectItem != null)
            {
                objectItem = null;
                HighlightCrosshair(false);
            }
        }
    
        void HighlightCrosshair(bool on)
        {
            _crosshair.color = on? Color.red : Color.magenta;
        }
    }
}
