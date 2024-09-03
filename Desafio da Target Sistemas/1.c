#include <stdio.h>
int main()
{
    int indice = 13, 
    soma = 0,
    K = 0;
    do {
        K = K + 1; 
        soma = soma + K;;
    } while (K < indice);
    
    printf("%d\n", soma);

    return 0; 
// 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 = 91
}