using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldVerticalDeadlineComponent : MonoBehaviour
{
    #region parameters
    #endregion
    #region references
    private Transform _myTransform;
    #endregion
    #region properties
    #endregion
    #region methods
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_myTransform.position.y <= 1)
        {
            Destroy(this.gameObject);
        }
    }
}
