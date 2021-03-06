using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovementController : MonoBehaviour
{
    #region parameters
    [SerializeField]
    private float _shotSpeed = 1.0f;
    #endregion
    #region references
    private Transform _myTransform;
    private BoxCollider2D _myBoxCollider2D;
    private Enemy_LifeComponent _myEnemyLifeComponent;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = GetComponent<Transform>();      
    }

    // Update is called once per frame
    void Update()
    {
        _myTransform.Translate(_shotSpeed * Vector3.up * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {         

         _myEnemyLifeComponent = collision.GetComponent<Enemy_LifeComponent>();

        if (_myEnemyLifeComponent != null)
        {
            _myEnemyLifeComponent.Damage();
            Destroy(this.gameObject);
        }
    }
}
