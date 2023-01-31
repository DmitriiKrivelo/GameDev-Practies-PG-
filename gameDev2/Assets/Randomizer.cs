using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Randomizer : MonoBehaviour
{
    [SerializeField] private Dictionary<int,string> _members;

    [SerializeField] private Text _indexText;
    [SerializeField] private Text _nameText;

    private void Start()
    {
        _members = new Dictionary<int, string>
        {
            {1,"Некрылов Андрей"},
            {2,"Потапов Тимур"},
            {3,"Полозов Михаил"},
            {4,"Чембирдиев Назар"},
            {5,"Адам"},
            {6,"Иванов Виктор"},
            {7,"Аверьянова Виолетта"},
            {8,"Захарин Владимир" },
            {9,"Прокопьев Данил"},
            {10,"Вишнивецкий Даниил"},
            {11,"Иванова Алина"},
            {12,"Кривело Дмитрий"},
            {13,"Токарь Даниил"},
            {14,"Асеев Иван"},
            {15,"Темури Хабиб"},
            {16,"Хорошилова Виктория"},
            {17,"Алехин"},
            {18,"Новиков"},
            {19,"Кудинова Дарья"},
            {20,"Тюрин Максим"},
            {21,"Скарынина Аня"},
            {22,"Руднев Юрий"},
            {23,"Будков Валерий"},
            {24,"Кашина Анжелина"},
            {25,"Ломакин Роман"},
            {26,"Воронина Мария"},
            {27,"Косенко Данил"},
            {28,"Бедрин Данила"},
            {29,"Кривцова Вероника"},
            {30,"Быков Алексей"},
            {31,"Самороковский Иван"}
        };
    }

    private string[] ShowRandomMember()
    {
        string[] result = new string[2];
        List<int> keys = new List<int>();

        foreach (KeyValuePair<int, string> pair in _members)
        {
            keys.Add(pair.Key);
        }

        int index = Random.Range(0, keys.Count);

        result[0] = (keys[index]).ToString();

        string output = "";
        _members.TryGetValue(keys[index], out output);

        result[1] = output;

        _members.Remove(keys[index]);

        return result;
    }

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (_members.Count == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                return;
            }

            string[] result = ShowRandomMember();

            _indexText.text = result[0];
            _nameText.text = result[1];
        }

        
    }*/

    [SerializeField] private GameObject _rotatedObject;

    private void FixedUpdate()
    {
        RotateToCursor(_rotatedObject);
    }

    private void RotateToCursor(GameObject gameObject)
    {
        Vector3 cursorPosition = new Vector3(Input.mousePosition.x, 0f, Input.mousePosition.y);
        Vector3 cursorWorldPosition = Camera.main.ScreenToWorldPoint(cursorPosition);

        gameObject.transform.LookAt(cursorWorldPosition);
    }
}