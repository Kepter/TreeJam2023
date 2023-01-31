using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowSpriteMaterial : MonoBehaviour
{
    private SpriteRenderer _renderer;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color.RGBToHSV(_renderer.color, out float h, out float s, out float v);
        _renderer.color = Color.HSVToRGB((h + Time.deltaTime * speed), s, v);
    }
}
