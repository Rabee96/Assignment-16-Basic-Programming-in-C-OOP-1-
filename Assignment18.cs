using UnityEngine;

namespace Assignment18
{
    struct Position
    {
        private float x,y,z;
        public Position(float _x,float _y,float _z){
            x = _x;
            y = _y;
            z = _z;
        }

        public readonly void PrintPosition(){
            Debug.Log($"the x position: {x}\nthe y position: {y}, the z position: {z}");
        }
    }
}

