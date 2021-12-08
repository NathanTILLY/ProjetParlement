using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class OnClick : MonoBehaviour
{
    public UnityEvent _onClick,_onClickUp, _onEnterOver,_onExitOver;

    public void OnMouseDown()
    {
        _onClick.Invoke();
    }

    private void OnMouseUp()
    {
        _onClickUp.Invoke();
    }

    public void OnMouseEnter()
    {
        _onEnterOver.Invoke();
    }

    private void OnMouseExit()
    {
        _onExitOver.Invoke();
    }

}
