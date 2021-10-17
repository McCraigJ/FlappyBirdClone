using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    [SerializeField]
    private float _scrollSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector2 currentTextureOffset = GetComponent<Renderer>().material.GetTextureOffset("_MainTex");

        float distanceToScrollLeft = Time.deltaTime * _scrollSpeed;

        float newTextureOffset_X = currentTextureOffset.x + distanceToScrollLeft;

        currentTextureOffset = new Vector2(newTextureOffset_X, currentTextureOffset.y);

        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", currentTextureOffset);
    }
}
