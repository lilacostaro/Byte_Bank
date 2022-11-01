﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            //teste.MetodoPrivado();
            //teste.MetodoProtegido();
            teste.MetodoInterno();
        }
        
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // visivel fora da classe "ModificadoresTeste"
        }

        private void MetodoPrivado()
        {
            // visivel apenas na classe "ModificadoresTeste"
        }

        protected void MetodoProtegido()
        {
            // visivel apenas na classe "ModificadoresTeste" e derivados
        }

        internal void MetodoInterno()
        {
            // visivel apenas para o projeto ByteBank.Modelos!
        }
    }
}
