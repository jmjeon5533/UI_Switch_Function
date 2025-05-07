using UnityEngine;

public class Menu_Management : MonoBehaviour
{
    UIManager.MenuState menuState;
    private Menu_Button[] moveButtons;
    public void Init(UIManager.MenuState menuState)
    {
        this.menuState = menuState;
        moveButtons = new Menu_Button[transform.childCount];
        for(int i = 0; i < transform.childCount; i++)
        {
            moveButtons[i] = transform.GetChild(i).GetComponent<Menu_Button>();
            moveButtons[i].parentMenuState = menuState;
        }
    }
}
