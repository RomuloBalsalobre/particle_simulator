using System;

namespace particle
{
    public class Particle
    {
        private string forma = "*";
        private int[] position = new int[2];
        public string _forma
        {
            get{return forma;}
        }

        public int[] _position
        {
            get{return position;}
        }
        public void _newPosition(int a, int b)
        {
            position[0] = a;
            position[1] = b;
        }
    }
}