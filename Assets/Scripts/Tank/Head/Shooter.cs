using UnityEngine;

namespace Tank.Head {
    public class Shooter : MonoBehaviour {
        [SerializeField] private GameObject _projectile;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private float _projectileForce;
        [SerializeField] private float _fireRate;
        
        private float _nextFireTime;

        private void Update() {
            if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFireTime) {
                GameObject projectile = Instantiate(_projectile, _shootPoint.position, Quaternion.identity);
                // Получаем компонент Rigidbody у снаряда
                Rigidbody rb = projectile.GetComponent<Rigidbody>();

                // Добавляем силу вперед в том направлении, в котором указывает оружие
                rb.AddForce(-transform.up  * _projectileForce, ForceMode.Impulse);

                // Устанавливаем время следующей стрельбы
                _nextFireTime = Time.time + _fireRate;
            }
        }
    }
}