using System;
using System.Collections.Generic;
using System.Text;

namespace Hra_Života
{
    public class Bunka
    {
        private bool _jeZiva;
        private int _posY;
        private int _posX;

        public Bunka(bool jeZiva, int posY, int posX)
        {
            this._jeZiva = jeZiva;
            this._posY = posY;
            this._posX = posX;
        }

        public bool JeZiva
        {
            get => _jeZiva;
            set
            {
                _jeZiva = value;
            }
        }

        public int PosY
        {
            get => _posY;
            set
            {
                _posY = value;
            }
        }

        public int PosX 
        {
            get => _posX;
            set
            {
                _posX = value;
            }
        }
        
    }
}
