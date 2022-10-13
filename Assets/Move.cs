using UnityEngine;

namespace Move
{
    public class Move : MonoBehaviour
    {
        public float speed = 2.0f;
        public float accuracy = 1f;
        public Transform goal;


        void Start()
        {
            
        }

        void LateUpdate()
        {
            Vector3 direction = goal.position - this.transform.position;
            if (direction.magnitude > accuracy)
            {
                this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
            }
            this.transform.LookAt(goal.position);
        }
    }
}

