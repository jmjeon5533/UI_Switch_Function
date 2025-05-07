
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Status
{
    public string name;
    public int HP;
    public int Power;
    public int Mana;

    public Status(string name, int hp, int power, int mana)
    {
        this.name = name;
        HP = hp;
        Power = power;
        Mana = mana;
    }
}
public class NewMonoBehaviourScript : MonoBehaviour
{
    public Dictionary<string, Status> dictionary = new Dictionary<string, Status>();
    void Start()
    {
        dictionary.Add("����", new Status("��ȣ��", 50, 10, 20));
        dictionary.Add("�̸���", new Status("�տ���", 200, 5, 50));

        Status charStatus = dictionary["������"];

        print($"name = {charStatus.name}");
        print($"HP = {charStatus.HP}");
        print($"Power = {charStatus.Power}");
        print($"Mana = {charStatus.Mana}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
