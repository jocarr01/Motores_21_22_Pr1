using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region parameters
    private bool _isGameRunning = true;
    private int score = 0;

    #endregion
    #region references
    private GameObject Score;
    private GameObject Player;
    private GameObject _GameOver;
    private float _duration = 2.0f;
    private float _elapsedTime = 0.0f;

    #endregion
    #region properties
    #endregion
    #region instances
    static private GameManager _instance;
    [SerializeField]
    private GameObject[] _squads;
    #endregion
    #region methods
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _instance = Instance;
        _squads[0].GetComponent<GameObject>();
        //Player = GameObject.Find("Fighter");
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        while (_isGameRunning)
        {
            _elapsedTime += Time.deltaTime;
            Debug.Log(_elapsedTime);
            if (_elapsedTime > _duration)
            {
                Debug.Log("Pim");
                Instantiate(_squads[0], new Vector3(1.5f, 3.4f, 0), Quaternion.identity);
                _elapsedTime = 0.0f;
            }
        }

    }
    public void OnEnemyDies(int scoreToAdd)
    {
        score = scoreToAdd;
        //Score.text = Score + score;
    }
    public void OnEnemyReachesBottomline()
    {
        _instance.GameOver();
    }
    public void OnPlayerDies()
    {
        _instance.GameOver();
    }
    private void GameOver()
    {
        //_GameOver.SetActive(true);        
        _isGameRunning = false;
        if (Player != null)
        {
            Debug.Log("Encontramos  jugador");
            Player.SetActive(false);
        }
        else
            Debug.Log("No encontramos  jugador");
    }
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }

            return _instance;
        }
    }
}
