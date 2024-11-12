using UnityEngine;

namespace Assignment18
{
    class Soldier : Character
    {
        public Soldier(string soldierName,int soldierHealth, Position soldierPosition):base(soldierName,soldierHealth,soldierPosition){
            
        }
        public Soldier():base(){

        }

        override public void DisplayInfo(){
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }

    class Officer : Character
    {
        public Officer(string officerName,int officerHealth, Position officerPosition):base(officerName,officerHealth,officerPosition){
            
        }
        public Officer():base(){

        }

        override public void DisplayInfo(){
            Debug.Log("Officer");
            base.DisplayInfo();
            
        }
    }
}

