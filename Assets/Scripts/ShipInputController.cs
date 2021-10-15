using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInputController : MonoBehaviour
{
    #region references
    private ShipMovementComponent _myShipMovementComponent;
    private Ship_AttackController _myShipAttackComponent;
    #endregion
    #region properties
    private Vector3 _desiredMovementDirection;
    private float _elapsedTime = 0.0f;
    private float _duration = 0.5f;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _myShipMovementComponent = GetComponent<ShipMovementComponent>();
        _myShipAttackComponent = GetComponent<Ship_AttackController>();
    }

    // Update is called once per frame
    void Update()
    {
        _desiredMovementDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            _desiredMovementDirection.y = 1.0f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _desiredMovementDirection.y = -1.0f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _desiredMovementDirection.x = -1.0f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _desiredMovementDirection.x = 1.0f;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //_elapsedTime += Time.deltaTime;
            //if (_elapsedTime > _duration)
            //{
            //    _myShipAttackComponent.Shoot(); 
            //    _elapsedTime = 0;
            //}
            _myShipAttackComponent.Shoot();
        }
        _desiredMovementDirection.Normalize();
        _myShipMovementComponent.SetMovementDirection(_desiredMovementDirection);
    }

}
