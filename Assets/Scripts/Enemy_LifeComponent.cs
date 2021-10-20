using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_LifeComponent : MonoBehaviour
{
    #region parameters
    [SerializeField]
    #endregion
    #region references
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
        //Damage();
    }
    public void Damage()
    {
        GameManager.Instance.OnEnemyDies(10);
        Destroy(this.gameObject);
    }
}
