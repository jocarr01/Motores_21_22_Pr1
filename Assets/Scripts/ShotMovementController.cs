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
    private int _myEnemyLayer;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = GetComponent<Transform>();
        _myBoxCollider2D = GetComponent<BoxCollider2D>();
        _myBoxCollider2D.isTrigger = true;
        _myEnemyLayer = LayerMask.NameToLayer("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        _myTransform.Translate(_shotSpeed * Vector3.up*Time.deltaTime);
       // Debug.Log("Update ");
    }

    //private void OnCollisionEnter2D(Collider2D collision)
    //{
    //    Debug.Log("He chocado con el objeto: " + collision.gameObject.name);
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
          Debug.Log("He chocado con el objeto: " + collision.gameObject.name);
        //collision.gameObject.GetComponent<Enemy_LifeComponent>().Damage();
    }
}
