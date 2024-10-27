using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFader : MonoBehaviour
{
    public float duration = 1.0f; // Duration of the transition
    private RectTransform rectTransform;
    private Vector2 startPosition;
    private Vector2 endPosition;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startPosition = rectTransform.anchoredPosition;
        endPosition = new Vector2(0, startPosition.y);
    }

    public void SlideIn()
    {
        
        StartCoroutine(SlideInCoroutine());
    }

    private IEnumerator SlideInCoroutine()
    {
        float elapsedTime = 0;
        

        while (elapsedTime < duration)
        {
            rectTransform.anchoredPosition = Vector2.Lerp(startPosition, endPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        rectTransform.anchoredPosition = endPosition;
        
    }
}
