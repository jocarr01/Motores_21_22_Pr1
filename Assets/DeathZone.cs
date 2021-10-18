using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    #region parameters
    [SerializeField]
    #endregion
    #region references
    private Enemy_LifeComponent _myEnemyLifeComponent;
    #endregion
    #region properties
    #endregion
    #region methods
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _myEnemyLifeComponent = collision.GetComponent<Enemy_LifeComponent>();

        if (_myEnemyLifeComponent != null)
        {
            GameManager.Instance.OnEnemyReachesBottomline();
        }
    }
}
