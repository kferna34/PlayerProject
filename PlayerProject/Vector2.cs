using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{/// <summary>
/// this class contains teo properties x andy which are related to geospatial info for game object
/// </summary>
// f == float d==decimal
    public class Vector2
    {

        private float _x;
        private float _y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;

        }

        public float x
        {
            get
            {
                return this._x;
            }

            set
            {
                this._x = value;

            }
        }

        public float y
        {
            get
            {
                return this._y;
            }

            set
            {
                this._y = value;
            }
        }

        public void Zero()
        {
            this.x = 0f;
            this.y = 0f;
        }

    }
}