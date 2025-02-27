using System;
using UnityEngine;

namespace New_Object_Logic
{
    public class ObjectInteractable : MonoBehaviour
    {
        private bool isNailed = false;
        private float direction = -0.1f;
        [SerializeField] private Vector3 LoosePosition;
        [SerializeField] public Vector3 tightPosition;
        [SerializeField] private float screwingSpeed = 2f;
        [SerializeField] private float ScrewLength = 2f;


        [SerializeField] bool isScrewTight;
        private bool isMoving = false;
        [SerializeField]private Vector3 targetPosition;

        public void Start()
        {
            LoosePosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
            tightPosition = new Vector3(transform.localPosition.x, LoosePosition.y-ScrewLength, transform.localPosition.z);

            
            

            
        }

        public void Update()
        {
            if (isMoving)
            {
                transform.localPosition = Vector3.Lerp(this.transform.localPosition, targetPosition, Time.deltaTime * screwingSpeed);
                if (Vector3.Distance(transform.localPosition, targetPosition)  < 0.1f)
                {
                    transform.localPosition = targetPosition;
                    isMoving = false;
                    Debug.Log("Done Moving! ");
                }
            }
        }

        public void ToggleScrewAction()
        {
            if (!isMoving)
            {
                isScrewTight = !isScrewTight;

                targetPosition = new Vector3(targetPosition.x, isScrewTight ? LoosePosition.y : tightPosition.y, targetPosition.z);
                isMoving = true;
            }
        }

        public void ObjectInteraction()
        {
            ToggleScrewAction();
            
        }
    }
}