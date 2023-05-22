using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic(int mahou)
    {
        Debug.Log(mahou + "のダメージを与えた");

      if(this.mp >= 5)
        {
           int c = this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + c);
        }
      else
        {
            Debug.Log("MPが足りない、魔法が使用できません。");
        }
    }
}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 20, 45, 90, 120, 229, 319 };
        for(int a =0; a < array.Length; a++)
        {
            Debug.Log(array[a]);
        }
        for(int b =5; b >=0; b--)
        {
            Debug.Log(array[b]);
        }
  
       

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
