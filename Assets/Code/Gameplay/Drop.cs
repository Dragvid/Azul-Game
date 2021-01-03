using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Drop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null) {
            if (eventData.pointerDrag.transform.parent.name == "Canvas")
            {
                eventData.pointerDrag.transform.SetParent(gameObject.transform);
                eventData.pointerDrag.transform.position = transform.position;
            }
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
