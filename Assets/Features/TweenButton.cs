using PrimeTween;
using UnityEngine;
using UnityEngine.EventSystems;

public class TweenButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RectTransform m_RectTransform;
    public float _highlightSize = 1.2f;
    public float _highlightDuration = 0.2f;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Tween.Scale(m_RectTransform, Vector3.one * _highlightSize, _highlightDuration, Ease.InSine);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Tween.Scale(m_RectTransform, Vector3.one, _highlightDuration, Ease.InSine);
    }

    private void Awake()
    {
        m_RectTransform = GetComponent<RectTransform>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }
}
