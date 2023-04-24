using System;
using System.Collections;
using UnityEngine;

namespace Tank.Head {
    public class Shooter : MonoBehaviour {
        [SerializeField] private GameObject _projectile;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private float _projectileForce;
        [SerializeField] private float _fireRate;

        private float _nextFireTime;
        private WaitForSeconds _delay;
        private Coroutine _attack;
        
        private void Start() {
            _attack = StartCoroutine(AttackRoutine());
        }

        public void SwitchAttackState() {
            if (_attack == null) {
                _attack = StartCoroutine(AttackRoutine());
            }
            else {
               StopCoroutine(_attack);
               _attack = null;
            }
        }

        // private void Update() {
        //     if (Input.GetKeyDown(KeyCode.Space)) {
        //         GameObject projectile = Instantiate(_projectile, _shootPoint.position, Quaternion.identity);
        //
        //         Rigidbody rb = projectile.GetComponent<Rigidbody>();
        //
        //         rb.AddForce(-transform.up * _projectileForce, ForceMode.Impulse);
        //
        //         _nextFireTime = Time.time + _fireRate;
        //     }
        // }

        private IEnumerator AttackRoutine() {
            while (true) {
                _delay = null;
                if (Input.GetKeyDown(KeyCode.Space)) {
                    GameObject projectile = Instantiate(_projectile, _shootPoint.position, Quaternion.identity);
                    Rigidbody rb = projectile.GetComponent<Rigidbody>();
                    rb.AddForce(-transform.up * _projectileForce, ForceMode.Impulse);
                    _delay = new WaitForSeconds(_fireRate);
                }

                yield return _delay;
            }
        }
    }
}