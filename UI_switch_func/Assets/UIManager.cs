using System;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance { get; private set; }
    public Stack<int> stackMoveStepsIndex = new Stack<int>();
    public Dictionary<MenuState, Action<int>> menuActionDic = new Dictionary<MenuState, Action<int>>();
    public enum MenuState
    {
        main,
        character,
        shop
    }

    public Transform panelParent;
    private GameObject[] menuPanels;
    void Awake()
    {
        instance = this;
    }
    public void PushMenuStack(int action) { stackMoveStepsIndex.Push(action); print(stackMoveStepsIndex.Count); }
    public int PopMenuStack() { return stackMoveStepsIndex.Count != 0 ? stackMoveStepsIndex.Pop() : -1; }
    void Start()
    {
        InitMenuAction();
        menuPanels = new GameObject[panelParent.childCount];
        for (int i = 0; i < panelParent.childCount; i++)
        {
            var curObjPanel = panelParent.GetChild(i).gameObject;
            curObjPanel.GetComponent<Menu_Management>().Init((MenuState)i);

            menuPanels[i] = curObjPanel;
        }
        SetMenu(MenuState.main);
    }
    private void InitMenuAction()
    {
        for(int i = 0; i < Enum.GetValues(typeof(MenuState)).Length; i++)
        {
            var num = i;
            menuActionDic.Add((MenuState)num, (i) => SetMenu((MenuState)num));
        }
    }
    public void SetMenu(MenuState newState)
    {
        for (int i = 0; i < menuPanels.Length; i++)
        {
            menuPanels[i].SetActive(i == (int)newState ? true : false);
        }
    }
}
