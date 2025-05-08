using UnityEngine;
using UnityEngine.UI;

public class Menu_Button : MonoBehaviour
{
    [HideInInspector]
    public UIManager.MenuState parentMenuState;
    public UIManager.MenuState targetMenuState;
    Button button;

    private void Start()
    {
        var u = UIManager.instance;
        button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            u.SetMenu(targetMenuState);
            u.PushMenuStack((int)parentMenuState);
        });
    }
}
