using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public abstract class Enemy : GameObject
    {
        private int _morale;

        public int Morale
        {
            get
            {
                return this._morale;
            }

            set
            {
                this._morale = value;
            }
        }

        public void Flee()
        {
            throw new System.NotImplementedException();
        }

        public void Seek()
        {
            throw new System.NotImplementedException();
        }
    }
}