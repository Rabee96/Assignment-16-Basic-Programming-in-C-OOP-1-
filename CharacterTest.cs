using Assignment18;
using UnityEngine;

namespace Assets.Scripts
{
    public class CharacterTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Soldier soldier = new();
            Officer officer = new("Jack sparrow",100,new(10,50,0));
            Character[] characters = {soldier,officer};

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }

            Debug.Log($"soldier {soldier.Name} health points are {characters[0].Health}");
            characters[1].Attack(50,characters[0]);
            characters[1].Attack(20,characters[0],"knife");
            Debug.Log($"soldier {soldier.Name} health points are {characters[0].Health}");
            
            characters[0].Health = 200;
            Debug.Log($"soldier {soldier.Name} health points are {characters[0].Health}");          
            characters[1].Attack(320,characters[0],"Rifle");
            Debug.Log($"soldier {soldier.Name} health points are {characters[0].Health}");

            characters[0].Health = 50;
            Debug.Log($"soldier {soldier.Name} health points are {characters[0].Health}");
            characters[1].Attack(-20,characters[0]);
            Debug.Log($"soldier {soldier.Name} health points are {characters[0].Health}");

        }
    }  
}

