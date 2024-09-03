#include <stdio.h>

#define NUM_ESTADOS 5

typedef struct {
    char estado[3];
    double valor;
} Faturamento;

int main() {
    Faturamento faturamento[NUM_ESTADOS] = {
        {"SP", 67836.43},
        {"RJ", 36678.66},
        {"MG", 29229.88},
        {"ES", 27165.48},
        {"Outros", 19849.53}
    };

    double totalFaturamento = 0.0;

    for (int i = 0; i < NUM_ESTADOS; i++) {
        totalFaturamento += faturamento[i].valor;
    }

    for (int i = 0; i < NUM_ESTADOS; i++) {
        double percent = (faturamento[i].valor / totalFaturamento) * 100;
        printf("%s: %.2f%%\n", faturamento[i].estado, percent);
    }

    return 0;
}
// SP: 34.43%
//RJ: 18.55%
//MG: 14.83%
//ES: 13.78%
//Outros: 10.05%