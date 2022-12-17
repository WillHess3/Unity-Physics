using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    [SerializeField] private float _coefficientOfFriction;

    [SerializeField] private PhysicMaterial _physicsMaterial;

    private void Update() {
        _physicsMaterial.staticFriction = _coefficientOfFriction;
        _physicsMaterial.dynamicFriction = _coefficientOfFriction;
    }

}
