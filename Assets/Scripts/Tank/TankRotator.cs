using UnityEngine;

namespace Tank {
    public class TankRotator : MonoBehaviour {
        public float mouseSensitivity = 100f;

        private Transform playerBody;

        float xRotation = 0f;

        void Start() {
            playerBody = transform.parent.transform;

            Cursor.lockState = CursorLockMode.Locked;
        }

        void Update() {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}