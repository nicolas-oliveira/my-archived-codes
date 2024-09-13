// Arquivo string.h.
// Interface da biblioteca string.
///////////////////////////////////////////////////////////

#ifndef _STRING_H
#define _STRING_H

#include <stddef.h>

// ////////////////////////////////////////////////////////
// Manipulação de strings
///////////////////////////////////////////////////////////


unsigned int strlen (char *x); 

// A função devolve o comprimento da string x. Em outras
// palavras, devolve o número de bytes de x (sem contar o
// \0 final).  O código da função tem o mesmo efeito que
//       for (i = 0; x[i] != 0; ++i) ;
//       return i;
// que por sua vez equivale a
//       y = x;
//       while (*y++) ;
//       return y-x-1;
// Uso típico: k = strlen (x);


char *strcpy (char *y, char *x);

// Copia a string x (inclusive o byte \0 final) no espaço
// alocado para a string y. Cabe ao usuário garantir que o
// espaço alocado a y tem pelo menos strlen(x) + 1 bytes.
// A função devolve y. Exemplo:
//       char y[4];
//       strcpy (y, "ABC");
// O código da função equivale a
//       for(i = 0; (y[i] = x[i]) != 0; ++i);
// que por sua vez equivale a
//       while (*y++ = *x++) ;
// Uso típico: strcpy (y, x);


char *strncpy (char *y, char *x, size_t n);

// Se strlen(x) < n então copia a string x (inclusive o \0
// final) para o espaço y. Se strlen(x) >= n então copia
// para y os n primeiros bytes de x e não acrescenta \0 ao
// final de y. Cabe ao usuário garantir que o espaço
// alocado a y tem pelo menos strlen(x) + 1 ou pelo menos
// n bytes. A função devolve y. Exemplo: 
//       char y[5];
//       strncpy (y, "ABCDE", 4);
// O código da função strncpy equivale a
//       for (i = 0; i < n && x[i] != '\0'; i++)
//           y[i] = x[i];
//       for  (; i < n; i++)
//           y[i] = '\0';
// Uso típico: strncpy (y, x, n);


char *strcat (char *, char *);

// Concatena as strings x e y, isto é, acrescenta y ao
// final de x. Devolve o endereço da string resultante,
// ou seja, devolve x. Cabe ao usuário garantir que o
// espaço alocado a x é suficiente para comportar strlen(y)
// bytes adicionais (após o \0 que marca o fim de x).
// Exemplo:
//       char x[7];
//       strcpy (x, "ABC"); 
//       strcat (x, "DEF");
// O código da função equivale a
//       strcpy (x + strlen (x), y);
// Uso típico: strcat (x, y);


int strcmp (char *x, char *y);

// Compara lexicograficamente as strings x e y. Devolve um
// número estritamente negativo se x vem antes de y,
// devolve 0 se x é igual a y e devolve um número
// estritamente positivo se x vem depois de y. O código da
// função equivale a 
//       for (i = 0; x[i] == y[i]; ++i)
//          if (x[i] == 0) return 0;
//       return x[i] - y[i];
// que por sua vez equivale a
//       while (*x++ == *y++)
//          if (*(x-1) == 0) return 0;
//       return *(x-1) - *(y-1);
// Uso típico: if (strcmp (x, y) == 0) ... ;


int strcoll (char *x, char *y);

// Esta função é análoga à strcmp mas não usa a ordenação
// dos caracteres imposta pela ordem crescente dos números
// Unicode. Em vez disso, a ordenação dos caracteres
// depende do valor da variável de ambiente LC_COLLATE.
// Uso típico: if (strcoll (x, y) == 0) ... ;


char *strtok (char *s, const char *d);

// Extrai tokens da string s. Um token é qualquer segmento
// maximal de s sem delimitadores. Um delimitador é
// qualquer byte da string d.
//    A string s pode ser vista como uma sequência de zero
// ou mais delimitadores, seguida de um ou mais não-
// delimitadores, seguida de um ou mais delimitadores, ...,
// seguida de um ou mais não-delimitadores, e finalmente
// seguida de zero ou mais delimitadores.
//    A função strtok transforma cada token em uma string
// (colocando um \0 na posição seguinte ao último byte do
// token) e devolve o (endereço do) token. Uma chamada a
// strtok com s != NULL devolve o primeiro token de s.
// Chamadas subsequentes com s == NULL devolvem o segundo,
// terceiro, etc. tokens.  O segundo argumento, d, pode ser
// diferente em cada chamada a strtok. Depois que todos os
// tokens forem encontrados, strtok devolve NULL.
//    Segue minha versão caseira de strtok, restrita aos
// delimitadores ' ' e ',':                                  
//    char *mystrtok (char *s) {
//       static char *restart;
//       char *token;
//       if (s == NULL) s = restart;
//       while (*s == ' ' || *s == ',') s++;
//       if (*s == '\0') return NULL;
//       token = s;
//       while (*s != ' ' && *s != ',' && *s != '\0') s++;
//       restart = s;
//       if (*s != '\0') {
//          *s = '\0';
//          restart++;
//       }
//       return token;
//    }
// Usos típicos: strtok (s, d); strtok (NULL, d);




#endif