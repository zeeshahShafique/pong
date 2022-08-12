using UnityEngine;
using UnityEngine.EventSystems;
public class TapToStartScreen : MonoBehaviour, IPointerDownHandler
{
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        gameObject.SetActive(false);
    }
    
}
