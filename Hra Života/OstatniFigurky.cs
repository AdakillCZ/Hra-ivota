using System;
using System.Collections.Generic;
using System.Text;

namespace Hra_Života
{
    public class Vez : Figurka
    {

        public override void ProvestTah()
        {
            throw new NotImplementedException();
        }
    }

    public class Strelec : Figurka
    {
        public override void ProvestTah()
        {
            throw new NotImplementedException();
        }
    }

    public class Pesak: Figurka
    {
        public override void ProvestTah()
        {
            throw new NotImplementedException();
        }
    }

    public class Kun : Figurka, Pohyb, Tah
    {
        public void pohybFigurky()
        {
            throw new NotImplementedException();
        }

        public override void ProvestTah()
        {
            throw new NotImplementedException();
        }

        public void tahFigurky()
        {
            throw new NotImplementedException();
        }
    }

    public interface Pohyb
    {
        void pohybFigurky();
    }

    public interface Tah
    {
        void tahFigurky();
    }
}
