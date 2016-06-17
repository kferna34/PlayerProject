using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public abstract class GameObject
    {
        private int _attack;
        private int _defense;
        private int _lives;
        private string _name;
        private int _speed;
        private int _direction;
        private int _position;

        public int Lives
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                this._name = Name;
            }
        }

        public int Strength
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Speed
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void MoveRight()
        {
            Console.WriteLine("{0} is moving  right ",this.Name);
        }

        public void MoveLeft()
        {
            Console.WriteLine("{0} is moving  left ", this.Name);
        }

        public void MoveForward()
        {
            Console.WriteLine("{0} is moving  forward ", this.Name);
        }

        public void MoveUp()
        {
            Console.WriteLine("{0} is moving up ", this.Name);
        }

        public void MoveBack()
        {
            Console.WriteLine("{0} is moving back ", this.Name);
        }

        public void TurnLeft()
        {
            Console.WriteLine("{0} is turning left ", this.Name);
        }

        public void TurnRight()
        {
            Console.WriteLine("{0} is turning right ", this.Name);
        }
    }
}