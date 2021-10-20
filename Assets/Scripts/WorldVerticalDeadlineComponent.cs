using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldVerticalDeadlineComponent : MonoBehaviour
{
    #region parameters
    #endregion
    #region references
    private Transform _myTransform;
    private GameObject _myDeadZone;
    private Transform _myDeadZonePosition;
    #endregion
    #region properties
    #endregion
    #region methods
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = GetComponent<Transform>();
        _myDeadZone = GameObject.Find("WorldLimitDown");
        _myDeadZonePosition = _myDeadZone.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (_myTransform.position.y <= 1)
        if (_myDeadZonePosition.position.y <= 1)
        {
            Destroy(this.gameObject);
        }
    }
}
