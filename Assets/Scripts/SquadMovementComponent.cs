using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadMovementComponent : MonoBehaviour
{
    #region parameters
    [SerializeField]
    private int _initialDirection=-1;
    private float _verticalSpeed=-0.1f;
    private float _horizontalSpeed=0.1f;
    private float _frequency=2.0f;
    #endregion
    #region references
    private Transform _myTransform;
    private float contador=0.0f;
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
        contador += Time.deltaTime;

        float seno = Mathf.Sin(contador*_frequency);
        Vector3 newDir = new Vector3((seno*_initialDirection)+_myTransform.position.x, _myTransform.position.y, 0);
        _myTransform.Translate(_verticalSpeed*newDir * Time.deltaTime);
        //Debug.Log(seno);
    }
}
