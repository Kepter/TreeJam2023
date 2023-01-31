using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowMaterial : MonoBehaviour
{
    private Material _material;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        _material = GetComponent<Renderer>().material;
        if (_material == null)
        {
            _material = GetComponent<SpriteRenderer>().material;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Color.RGBToHSV(_material.color, out float h, out float s, out float v);
        _material.color = Color.HSVToRGB((h + Time.deltaTime * speed), s, v);
    }
}
