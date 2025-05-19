using PrimeTween;
using UnityEngine;
using UnityEngine.InputSystem;

public class TweenPanel : MonoBehaviour
{
    private RectTransform m_RectTransform;
    private InputSystem_Actions m_Actions;

    private void Awake()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //Tween.PositionX(transform, 0,1,Ease.InSine);
        m_Actions = new InputSystem_Actions();
        m_Actions.Player.Menu.performed += OpenMenu;
        m_Actions.UI.Menu.performed += CloseMenu;
        m_Actions.UI.Disable();
    }

    public void OpenMenu(InputAction.CallbackContext context)
    {
        Debug.Log("Opening Menu");
        Tween.PositionX(transform, 0, 1, Ease.InSine);
    }


    public void CloseMenu(InputAction.CallbackContext context)
    {
        Debug.Log("Closing Menu");
        Tween.PositionX(transform, -250, 1, Ease.InSine);
    }
}
