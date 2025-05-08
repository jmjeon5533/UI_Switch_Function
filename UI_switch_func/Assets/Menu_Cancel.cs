using UnityEngine;
using UnityEngine.UI;

public class Menu_Cancel : MonoBehaviour
{
    Button button;

    private void Start()
    {
        var u = UIManager.instance;
        button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            var menuNumber = u.PopMenuStack();
            if (menuNumber == -1) return;
            u.menuActionDic[(UIManager.MenuState)menuNumber].Invoke((int)menuNumber);
        });
    }
}
