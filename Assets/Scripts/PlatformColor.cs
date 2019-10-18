using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    public void BallTouchThis()
    {
        _spriteRenderer.color = GetRandomColor();
    }

    private void Start()
    {
        _spriteRenderer = transform.GetComponent<SpriteRenderer>();
    }

    private Color GetRandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
