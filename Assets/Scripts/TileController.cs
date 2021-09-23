using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public int id;

    private BoardManager _board;
    private SpriteRenderer _render;

    private void Awake()
    {
        _board = BoardManager.Instance;
        _render = GetComponent<SpriteRenderer>();
    }

    public void ChangeId(int newId, int x, int y)
    {
        _render.sprite = _board.tileTypes[newId];
        this.id = newId;

        name = $"TILE_{id} ({x}, {y})";
    }
}
