# Analise de faturamento anual de uma empresa
Neste programa, assumimos que o vetor faturamentoDiario já está preenchido com os valores de faturamento diário ao longo de um ano.

Para calcular o menor valor de faturamento, percorremos o vetor e comparamos cada valor com a variável menorValor. Se o valor atual for menor que menorValor, atualizamos o menorValor para o valor atual. No final do loop, menorValor conterá o menor valor de faturamento.

Para calcular o maior valor de faturamento, fazemos algo semelhante, percorrendo o vetor e comparando cada valor com a variável maiorValor. Se o valor atual for maior que maiorValor, atualizamos o maiorValor para o valor atual. No final do loop, maiorValor conterá o maior valor de faturamento.

Para calcular o número de dias em que o faturamento diário foi superior à média anual, primeiro calculamos a soma de todos os valores de faturamento diário. Em seguida, dividimos essa soma pelo número de elementos do vetor para obter a média anual. Finalmente, percorremos o vetor novamente e contamos quantos valores são maiores que a média anual, incrementando a variável diasComFaturamentoAcimaMedia. No final do loop, diasComFaturamentoAcimaMedia conterá o número de dias em que o faturamento diário foi superior à média anual.
