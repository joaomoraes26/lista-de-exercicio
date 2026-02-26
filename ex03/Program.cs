public class Distancia { 
public static void main(String[] args) { 

Scanner teclado = new Scanner(); 

double x1, y1, x2, y2, distancia; 

Console.WriteLine("Entre com as coordenadas x e y dos pontos nesta ordem:"); 

x1 = teclado.nextFloat(); 
y1 = teclado.nextFloat(); 
x2 = teclado.nextFloat(); 
y2 = teclado.nextFloat(); 

// o erro está na divisão no final da conta de distancia, onde dividir 1/2 a linguagem java reconhece como um numero inteiro.

distancia = Math.sqrl(Math.pow(x2-x1, 2) + Math.pow(y2-y1, 2)); 

Console.WriteLine("A distância é: " + distancia); 
 } 
}