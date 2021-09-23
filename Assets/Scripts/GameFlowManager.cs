using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameFlowManager : MonoBehaviour
{
    #region Singleton

    private static GameFlowManager _instance;

    public static GameFlowManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameFlowManager>();

                if (_instance == null)
                {
                    Debug.LogError("GameFlowManager Not Found!");
                }
            }
            return _instance;
        }
    }

    [Header("UI")]
    public UIGameOver GameOverUI;

    #endregion

    private bool _isGameOver;
    
    public bool IsGameOver => _isGameOver;

    private void Start()
    {
        _isGameOver = false;
    }

    public void GameOver()
    {
        _isGameOver = true;
        if (ScoreManager.Instance.CurrentScore > ScoreManager.Instance.HighScore)
        {
            ScoreManager.Instance.SetHighScore();
        }
        
        GameOverUI.Show();
    }
}
