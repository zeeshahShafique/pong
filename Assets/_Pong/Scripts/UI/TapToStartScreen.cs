using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class TapToStartScreen : MonoBehaviour, IPointerDownHandler
{
    public static UnityEvent StartScreenTapped = new UnityEvent();

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        StartScreenTapped.Invoke();
        InputController.Enabled = true;
    }
    
}
