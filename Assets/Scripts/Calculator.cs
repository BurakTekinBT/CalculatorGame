using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    int number1, number2;
    int sum;
    public Text SumNumber;
    public InputField num1, num2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Addition()
    {
        number1 = int.Parse(num1.text);
        number2 = int.Parse(num2.text);
        sum = number1 + number2;
        SumNumber.text = sum.ToString();
    }

    public void Substriction()
    {
        number1 = int.Parse(num1.text);
        number2 = int.Parse(num2.text);
        sum = number1 - number2;
        SumNumber.text = sum.ToString();
    }

    public void Multiply()
    {
        number1 = int.Parse(num1.text);
        number2 = int.Parse(num2.text);
        sum = number1 * number2;
        SumNumber.text = sum.ToString();
    }

    public void Divison()
    {
        number1 = int.Parse(num1.text);
        number2 = int.Parse(num2.text);

        float sum2 = (float)number1 / (float)number2;
        SumNumber.text = sum2.ToString();
    }
}
