using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropScript : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler
{

    public Canvas canvas;
    private RectTransform RectTransform;
    private RectTransform canvasRectTransform;
    private Vector2 cursorOffset;
    private SFXScript sfx;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 localCursorPosition = GetLocalCursorPosition(eventData);
        cursorOffset = RectTransform.anchoredPosition - localCursorPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localCursorPosition = GetLocalCursorPosition(eventData);
        RectTransform.anchoredPosition = localCursorPosition + cursorOffset;


    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag called!");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        sfx.PlaySFX(0);
    }

    private Vector2 GetLocalCursorPosition(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRectTransform, eventData.position, canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : canvas.worldCamera, out Vector2 localPos);

        return localPos;
    }

    void Start()
    {
        RectTransform = GetComponent<RectTransform>();
        canvasRectTransform = canvas.transform as RectTransform;
        sfx = FindFirstObjectByType<SFXScript>();
    }
}
