using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class Scaling : MonoBehaviour
{
    public Slider _startScale;
    public Transform TouchPoint;

    public Renderer Renderer;

    private void Start()
    {
        _startScale.value = transform.localScale.x;
    }

    public void Scale(float value)
    {
        transform.localScale = new Vector3(value, value, value);
        var transformLocalPosition = transform.position;
        transformLocalPosition.y = TouchPoint.position.y;
    }
    
    public void SetMaterial(Material material)
    {
        Renderer.material = material;
    }
}
