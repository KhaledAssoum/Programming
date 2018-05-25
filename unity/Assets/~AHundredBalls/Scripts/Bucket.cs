using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AHundredBalls
{
    

    public class Bucket : MonoBehaviour
    {
        public float movementSpeed = 10f;

        private Rigidbody2D rigid2D;
        private Renderer[] renderers;

        public Vector2 direction = Vector2.right;

        // Use this for initialization
        void Start()
        {
            rigid2D = GetComponent<Rigidbody2D>();

            renderers = GetComponentsInChildren<Renderer>();

            transform.position += (Vector3)direction * movementSpeed * Time.deltaTime;
        }

        // Update is called once per frame
        void Update()
        {
            HandlePosition();
            HandleBoundary(); 
        }

        void HandlePosition()
        {
            rigid2D.velocity = Vector3.left * movementSpeed;
        }

        void HandleBoundary()
        {
            Vector3 transformPos = transform.position;

            Vector3 viewportPos = Camera.main.WorldToViewportPoint(transformPos);

            if (isVisible() == false && viewportPos.x < 0)
            {
                Destroy(gameObject);
            }
        }

        bool isVisible()
        {
            foreach (var renderer in renderers)
            {
                if (renderer.isVisible)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
