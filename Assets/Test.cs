using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53;

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    public void Magic(int mahou)
    {
        Debug.Log(mahou + "�̃_���[�W��^����");

      if(this.mp >= 5)
        {
           int c = this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + c);
        }
      else
        {
            Debug.Log("MP������Ȃ��A���@���g�p�ł��܂���B");
        }
    }
}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
     
       
        Boss lastboss = new Boss();

       
        lastboss.Attack();
        
        lastboss.Defence(3);

        for(int i = 0; i<=10; i++)
        {
            lastboss.Magic(150);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
