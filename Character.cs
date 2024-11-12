using UnityEngine;

namespace Assignment18
{
   class Character
   {
        public Character(string characterName,int characterHealth, Position characterPosition){
            Name = characterName;
            health = characterHealth;
            position = characterPosition;
        }
        public Character():this("John Doe", 100, new(0,0,0)){
            
        }
        public string Name { get; }
        private int health;
        public int Health
        {
            get => health;
            set => health = value <= 0 ? 0 : value >= 100 ? 100 : value;
        }
        protected Position position;

        virtual public void DisplayInfo(){
            Debug.Log($"You've selected {Name}\n{Name} health points : {health}.");
            position.PrintPosition();
        }

        public void Attack(int damage,Character target){
            if (damage >= 0)
            {
                target.Health -= damage;
                Debug.Log($"{Name} inflict {damage} damage points to {target.Name}.");
            }else
                Debug.Log("Are trying to heal'em or what ? 🤨");
        }
        public void Attack(int damage,Character target,string attackType){
            Attack(damage,target);
            Debug.Log($"You\'ve used {attackType} for attacking {target.Name}.");
        }
   }
}

