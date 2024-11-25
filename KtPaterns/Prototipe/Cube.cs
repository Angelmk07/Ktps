using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KtPaterns.Prototipe
{
    internal class Cube : Base
    {
        private Vector3 _position;
        private Color _color;
        private Vector3 _scale;
        private Vector3 _rotation;
        public Cube()
        {

        }
        public Cube(Vector3 _position, Vector3 _scale, Vector3 _rotation)
        {
            this._position = _position;
            this._scale = _scale;
            this._rotation = _rotation;
        }

        public void info()
        {
            Console.WriteLine(_position.ToString(), _color, _scale, _rotation);
        }

        public void SetColor(Color color)
        {
            _color = color;
        }
        public void SetRotation(Vector3 value)
        {
            _rotation = value;
        }
        public void SetScale(Vector3 value)
        {
            _position = value;
        }

        public Base clone()
        {
            return new Cube();
        }
    }
}
