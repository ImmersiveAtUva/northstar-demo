using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BasicCalc : MonoBehaviour
{

    private TextMesh inputBox;
    private static double firstNumber;
    private static char operation = '+';
   

    
  
    void Start()
    {

        inputBox = GameObject.Find("InputBox").GetComponent<TextMesh>();
        
    }

    //user taps one button then we set our input text to 1 
    public void nOne()
    {
        if (inputBox.text == "0" && inputBox.text != null )
        {
            inputBox.text = "1";
        }
        else
        {
            inputBox.text += "1";
        }
    }

    //user taps two button then we set our input text to 2
    public void nTwo()
    {
        if (inputBox.text == "0" && inputBox.text != null)
        {
            inputBox.text = "2";
        }
        else
        {
            inputBox.text += "2";
        }
        
    }

    public void nThree()
    {
        if (inputBox.text == "0" && inputBox.text != null)
        {
            inputBox.text = "3";
        }
        else
        {
            inputBox.text += "3";
        }

    }

    public void nFour()
    {
        if (inputBox.text == "0" && inputBox.text != null)
        {
            inputBox.text = "4";
        }
        else
        {
            inputBox.text += "4";
        }

    }

    public void nFive()
    {
        if (inputBox.text == "0" && inputBox.text != null)
        {
            inputBox.text = "5";
        }
        else
        {
            inputBox.text += "5";
        }

    }

    public void nSix()
    {
        if (inputBox.text == "0" && inputBox.text != null)
        {
            inputBox.text = "6";
        }
        else
        {
            inputBox.text += "6";
        }

    }

    public void nSeven()
    {
        if (inputBox.text == "0" && inputBox.text != null)
        {
            inputBox.text = "7";
        }
        else
        {
            inputBox.text += "7";
        }

    }

    public void nEight()
    {
        if (inputBox.text == "0" && inputBox.text != null)
        {
            inputBox.text = "8";
        }
        else
        {
            inputBox.text += "8";
        }

    }

    public void nNine()
    {
        if (inputBox.text == "0" && inputBox.text != null)
        {
            inputBox.text = "9";
        }
        else
        {
            inputBox.text += "9";
        }

    }

    public void nZero()
    {
       inputBox.text += "0";
        
    }

    public void nDecimal()
    {
        inputBox.text += ".";
    }

    public void Clear()
    {
        firstNumber = 0;
        inputBox.text = "0";
        inputBox.fontSize = 500;
    }


    //user taps add button we convert out input text from a string to a double(a number) and assign what operation we plan to do 
    public void Add()
    {
        firstNumber = double.Parse(inputBox.text);
        Debug.Log("First Number Parsed: " + firstNumber);
        operation = '+';
        inputBox.text = "0";
        inputBox.fontSize = 500;
    }

    public void Subtract()
    {
        firstNumber = double.Parse(inputBox.text);
        Debug.Log("First Number Parsed: " + firstNumber);
        operation = '-';
        inputBox.text = "0";
        inputBox.fontSize = 500;
    }

    public void Multiply()
    {
        firstNumber = double.Parse(inputBox.text);
        Debug.Log("First Number Parsed: " + firstNumber);
        operation = '*';
        inputBox.text = "0";
        inputBox.fontSize = 500;
    }

    public void Divide()
    {
        firstNumber = double.Parse(inputBox.text);
        Debug.Log("First Number Parsed: " + firstNumber);
        operation = '/';
        inputBox.text = "0";
        inputBox.fontSize = 500;
    }

    public void Equal() 
    {

        double secondNumber;
        double result = 0.0;
        
        
        secondNumber = double.Parse(inputBox.text);
        Debug.Log("Second Number Parsed: " + secondNumber);

        if (operation == '+')
        {
            result = firstNumber + secondNumber;
            inputBox.text = result.ToString(); //"#,##"
            firstNumber = result;
            if (result.ToString().Length > 7)
            {
                inputBox.fontSize = 300;
            }
            else if(result.ToString().Length > 10)
            {
                inputBox.fontSize = 200;
            }
            Debug.Log("Sum: " + result);
        }
        else if (operation == '-')
        {
            result = firstNumber - secondNumber;
            inputBox.text = result.ToString();
            firstNumber = result;
            if (result.ToString().Length > 7)
            {
                inputBox.fontSize = 300;
            }
            else if (result.ToString().Length > 10)
            {
                inputBox.fontSize = 200;
            }
            Debug.Log("Difference: " + result);
        }
        else if (operation == '*')
        {
            result = firstNumber * secondNumber;
            inputBox.text = result.ToString();
            firstNumber = result;
            if (result.ToString().Length > 7)
            {
                inputBox.fontSize = 300;
            }
            else if (result.ToString().Length > 10)
            {
                inputBox.fontSize = 200;
            }
            Debug.Log("Product: " + result);
        }
        else if (operation == '/')
        {
            if (secondNumber == 0)
            {
                inputBox.text = "error";
            }
            else
            {
                result = firstNumber / secondNumber;
                inputBox.text = result.ToString("");
                firstNumber = result;
                if (result.ToString().Length > 7)
                {
                    inputBox.fontSize = 300;
                }
                else if (result.ToString().Length > 10)
                {
                    inputBox.fontSize = 200;
                }
                Debug.Log("quotient: " + result);
            }
        }
        




    }

    

   


    
}
