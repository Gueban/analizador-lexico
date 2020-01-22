using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_léxico
{
    class Analizador_Léxico
    {

        //variable para saber mi esado actual
        int estado_actual;
        //variable que guarda lexemas
        string lexema;
        //lista donde guardo los tokens
        LinkedList<token> mi_lista;

        public LinkedList<token> analizar(string text)
        {
            //agrego un númeral para saber cuando tengo que terminar
            text += "#";
            //inicializo mi lista
            mi_lista = new LinkedList<token>();
            //variable para ir caracter a caracter
            char car;
            lexema = "";
            for (int a = 0; a < text.Length; a++)
            {
                car = text[a];
                switch (estado_actual)
                {
                    case 0:
                        if (Char.IsLetter(car))
                        {
                            //si viene una letra lo mando al estado #1
                            estado_actual = 1;
                            a--;
                        }
                        else if (Char.IsDigit(car))
                        {
                            //si viene un número lo mando al estado #2
                            estado_actual = 2;
                            a--;
                        }
                        else if(car.Equals(' '))
                        {
                            //si vienen espacios en blanco los ignoro
                        }
                        else
                        {
                            if (car.Equals('#'))
                            {
                                //como se topa con el numeral se qu finalizo el análisis
                                Console.WriteLine("Fin de análisis");
                            }
                            else
                            {
                                Console.WriteLine("Error: "+car);
                            }
                        }
                        break;
                    case 1:
                        if (Char.IsLetter(car))
                        {
                            //si vienen mas letras las junto para hacer mi lexema
                            lexema += car;
                        }
                        else
                        {
                            //agrego a la lista de tokens 
                            addtoken(token.tipo.LETRA);
                        }
                        break;
                    case 2:
                        if (Char.IsDigit(car))
                        {
                            //si vienen mas números los junto para hacer el lexema
                            lexema += car;
                        }
                        else
                        {
                            //lo agrego a mi lista de tokens
                            addtoken(token.tipo.NUMERO);
                        }
                        break;
                }
            }
            return mi_lista;
        }

        //agrego un token a mi lista de tokens
        public void addtoken(token.tipo t)
        {
            mi_lista.AddLast(new token(t, lexema));
            lexema = "";
            estado_actual = 0;
        }

        //muestro los token que analizo
        public void show_tokens()
        {
            foreach(token a in mi_lista)
            {
                Console.WriteLine("Tipo: " + a.get_st_tipo()+" Lexema: "+a.get_value());
            }
        }
    }
}
