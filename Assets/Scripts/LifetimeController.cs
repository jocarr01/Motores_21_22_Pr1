using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifetimeController : MonoBehaviour
{
    #region parameters
    [SerializeField]
    private float _duration = 1.0f;
    #endregion
    #region properties
    private float _elapsedTime;
    #endregion
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime > _duration)
        {
            Destroy(gameObject);
        }
    }
}
