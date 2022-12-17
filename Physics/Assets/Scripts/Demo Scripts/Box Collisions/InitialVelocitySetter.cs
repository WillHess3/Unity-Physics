using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialVelocitySetter : MonoBehaviour {

    [SerializeField] private List<Rigidbody> _elasticBoxes;
    [SerializeField] private List<Rigidbody> _inelasticBoxes;
    [SerializeField] private List<Rigidbody> _perfectlyInelasticBoxes;

    [SerializeField] private float _box1InitialVelocity;
    [SerializeField] private float _box2InitialVelocity;

    [Min(0.0001f)]
    [SerializeField] private float _box1mass;
    [Min(0.0001f)]
    [SerializeField] private float _box2mass;



    private void Start() {
        _elasticBoxes[0].velocity = new Vector3(_box1InitialVelocity, 0, 0);
        _inelasticBoxes[0].velocity = new Vector3(_box1InitialVelocity, 0, 0);
        _perfectlyInelasticBoxes[0].velocity = new Vector3(_box1InitialVelocity, 0, 0);

        _elasticBoxes[1].velocity = new Vector3(_box2InitialVelocity, 0, 0);
        _inelasticBoxes[1].velocity = new Vector3(_box2InitialVelocity, 0, 0);
        _perfectlyInelasticBoxes[1].velocity = new Vector3(_box2InitialVelocity, 0, 0);

        _elasticBoxes[0].mass = _box1mass;
        _inelasticBoxes[0].mass = _box1mass;
        _perfectlyInelasticBoxes[0].mass = _box1mass;

        _elasticBoxes[1].mass = _box2mass;
        _inelasticBoxes[1].mass = _box2mass;
        _perfectlyInelasticBoxes[1].mass = _box2mass;
    }
}
