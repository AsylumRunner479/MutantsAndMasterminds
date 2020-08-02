using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    public int number0;
    public int number1;
    public int number2;
    public int number3;
    public int number4;
    public int number5;
    public int number6;
    public int number7;
    public int number8;
    public int number9;
    public int number100;
    public void Random10()
    {
        number0 = Random.Range(0, 10);
        number1 = Random.Range(0, 10);
        number2 = Random.Range(0, 10);
        number3 = Random.Range(0, 10);
        number4 = Random.Range(0, 10);
        number5 = Random.Range(0, 10);
        number6 = Random.Range(0, 10);
        number7 = Random.Range(0, 10);
        number8 = Random.Range(0, 10);
        number9 = Random.Range(0, 10);
        number100 = number0 + number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8 + number9;
        
    }
    public void DoubleRandom3()
    {
        Random3();
        number1 = number0;
        while (number1 == number0)
        {
            Random3();
        }
    }
    public void DoubleRandom4()
    {
        Random4();
        number1 = number0;
        while (number1 == number0)
        {
            Random4();
        }
    }
    public void DoubleRandom5()
    {
        Random5();
        number1 = number0;
        while (number1 == number0)
        {
            Random5();
        }
    }
    public void DoubleRandom6()
    {
        Random6();
        number1 = number0;
        while (number1 == number0)
        {
            Random6();
        }
    }
    public void DoubleRandom7()
    {
        Random7();
        number1 = number0;
        while (number1 == number0)
        {
            Random6();
        }
    }
    public void TripleRandom7()
    {
        DoubleRandom7();
        number2 = number1;
        while (number2 == number1)
        {
            DoubleRandom7();
        }
    }
    public void Random2()
    {
        number0 = Random.Range(0, 1);

    }
    public void AltRandom2()
    {
        number5 = Random.Range(0, 1);

    }
    public void Random3()
    {
        number0 = Random.Range(0, 2);

    }
    public void Random4()
    {
        number0 = Random.Range(0, 3);

    }
    public void Random5()
    {
        number0 = Random.Range(0, 4);

    }
    public void Random6()
    {
        number0 = Random.Range(0, 5);

    }
    public void Random7()
    {
        number0 = Random.Range(0, 6);

    }
    public void Random15()
    {
        number0 = Random.Range(0, 14);

    }
    public void Random20()
    {
        number0 = Random.Range(1, 20);
       
    }
    public void Random1010()
    {
        number1 = 0;
        for (int i = 0; i < 10; i++)
        {
            number0 = 0;
            Random10();
            number1 += number0;
            
        }
        Debug.Log(number0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
