using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class LetterC : MonoBehaviour, IClickable
{
    private MeshRenderer _renderer;
    private Material _material;
    private Color _transparent;
    private Color _opaque;   

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
        _material = _renderer.material;
        _transparent = _material.color;
        _transparent.a = 0;
        _opaque = _material.color;
    }
    public void OnClick()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_material.DOColor(_transparent, 2.0f));
        sequence.AppendInterval(1.1f);
        sequence.Append(_material.DOColor(_opaque, 2.0f));
        sequence.Play();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}