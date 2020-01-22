using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_léxico
{
    class token
    {
        public enum tipo
        {
            LETRA,
            NUMERO
        }

        public tipo tipo_token;
        public string value;

        public token(tipo t, string v)
        {
            this.tipo_token = t;
            this.value = v;
        }

        public string get_value()
        {
            return this.value;
        }

        public tipo get_tipo()
        {
            return this.tipo_token;
        }

        public string get_st_tipo()
        {
            switch (tipo_token)
            {
                case tipo.LETRA:
                    return "Letra o Palabra";
                    break;
                case tipo.NUMERO:
                    return "Número";
                    break;
                default:
                    return "ERROR";
                    break;
            }
        }

    }
}
