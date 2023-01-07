using UnityEngine;

namespace Tank {
    public class TankRotator : MonoBehaviour {
        [SerializeField] private float _speed;

        void Update() {
            if (Input.GetKey(KeyCode.Comma))
            {
                transform.Rotate(Vector3.forward, -1f * _speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.Period))
            {
                transform.Rotate(Vector3.forward, 1f * _speed * Time.deltaTime);
            }
            
        }
    }
}
