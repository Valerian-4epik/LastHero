using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour {
    [SerializeField] private GameObject _tank;
    private Image _image;
    private float _health;

    private void Awake() {
        _image = GetComponent<Image>();
    }

    private void Start() {
        _health = 1;
        StartCoroutine(TakeDamageRoutine(0.1f));
    }

    private void SetValue(float value) {
        _image.fillAmount = value;
    }

    private IEnumerator TakeDamageRoutine(float damage) {
        while (_health > 0) {
            _health -= damage;
            SetValue(_health);

            yield return new WaitForSeconds(0.8f);
        }

        Destroy(_tank);
    }
}