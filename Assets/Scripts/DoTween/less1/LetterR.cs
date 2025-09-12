using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class LetterR : MonoBehaviour, IClickable
{
    private MeshRenderer _renderer;
    private Material _material;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
        _material = _renderer.material;
    }
    public void OnClick()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_material.DOColor(Color.red, 2.0f ));
        sequence.AppendInterval(1.1f);
        sequence.Append(_material.DOColor(Color.white, 2.0f));
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
