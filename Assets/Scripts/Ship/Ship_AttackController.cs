using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_AttackController : MonoBehaviour
{
    #region parameters
    //private float _duration = 0.5f;
    #endregion
    #region references
    private Transform _myTransform;
    [SerializeField]
    private GameObject p_Shot;
    #endregion
    #region properties
    private float _elapsedTime;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shoot()
    {
        Instantiate(p_Shot, new Vector3(_myTransform.position.x, _myTransform.position.y, 0), Quaternion.identity);
    }   
}
