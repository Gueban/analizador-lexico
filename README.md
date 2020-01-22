# analizador-lexico
una pequeño ejemplo de analizador léxico en C#, que acepta letras, números y espacios.
En al archivo token se encuentra la clase que uso para crear el tipo de dato token que uso mas adelante para guardar en una lista generica los lexemas y su tipo.
El archivo Analizador Léxico esta la lógica del analizador y los métodos de guardar en la lista de tokens y de mostrar la misma.
En al archivo Form es donde instancio y llamo las funciones para hacer el análisis de la cadena.
En el archivo automata se encuentra el automata que use para diseñar el analizador en donde L se refiere a las letras, D a los dígitos y F a los caracteres no aceptados por el lenguaje
