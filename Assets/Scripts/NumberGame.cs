using UnityEngine;

public class NumberGame : MonoBehaviour
{
    #region Variables

    private readonly int _totalSum = 50;

    private int _moves;
    private int _sum;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        Debug.Log("Добро пожаловать в Number Game!");
        NewGame();
    }

    private void Update()
    {
        for (int i = 1; i <= 9; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                AddToSum(i);
            }
        }
    }

    #endregion

    #region Private methods

    private void AddToSum(int number)
    {
        _sum += number;
        _moves++;
        Debug.Log($"Сумма: {_sum}");

        if (_sum >= _totalSum)
        {
            Debug.Log($"Игра окончена! Количество ходов: {_moves} ");
            NewGame();
        }
    }

    private void NewGame()
    {
        _sum = 0;
        _moves = 0;
        Debug.Log("Нажнимите цифру:");
    }

    #endregion
}