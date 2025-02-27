using System;
using UnityEngine;

namespace New_Object_Logic
{
    public class ObjectItem : MonoBehaviour
    {
        public enum ObjectType
        {
            None,
            Object,
            Tool
        }
        
        [Header("Object Type")]
        [SerializeField] private ObjectType objectType = ObjectType.None;
        
        private ObjectInteractable objectInteractable;
        private ToolCollectable toolCollectable;

        private void Awake()
        {
            switch (objectType)
            {
            case ObjectType.Object: objectInteractable = GetComponent<ObjectInteractable>(); break;
            case ObjectType.Tool: toolCollectable = GetComponent<ToolCollectable>(); break;
            }
        }

        public void ObjectInteraction()
        {
            switch (objectType)
            {
                
            case ObjectType.Object: objectInteractable?.ObjectInteraction(); Debug.Log("interacting with object");break;
            case ObjectType.Tool: toolCollectable?.ToolPickup();
                Debug.Log("Tool picked up");break;
            }
        }
    }
}