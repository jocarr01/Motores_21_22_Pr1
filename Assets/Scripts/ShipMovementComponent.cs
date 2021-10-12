using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementComponent : MonoBehaviour
{
    // Start is called before the first frame update
    #region parameters
    [SerializeField]
    private float _movementSpeed=1.0f;
    #endregion
    #region references
    private Transform _myTransform;
    #endregion
    #region properties
    private Vector3 _movementDirection;
    #endregion
    #region methods
    public void SetMovementDirection (Vector3 newMovementDirection)
    {
        _movementDirection = newMovementDirection;
    }
    #endregion
    void Start()
    {
        _myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_movementSpeed * _movementDirection * Time.deltaTime);
    }
}
