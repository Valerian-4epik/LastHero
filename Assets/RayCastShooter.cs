using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShooter : MonoBehaviour {
    // private void OnDrawGizmos() {
    //     Gizmos.color = Color.blue;
    //     Gizmos.DrawRay(transform.position, Vector3.right * 10);
    // }

    private void Start() {
        ShootRayCast();
    }

    private void ShootRayCast() {
        RaycastHit2D[] hit2D;
        hit2D = Physics2D.RaycastNonAlloc(transform.position, Vector2.right * 10);
        
        print(hit2D.Length);
        
        // if (hit2D.collider.TryGetComponent(out HpBar hpBar)) {
        //     Destroy(hit2D.collider.gameObject);
        // }
        // else {
        //     print("нет бара");
        // }
    }
}