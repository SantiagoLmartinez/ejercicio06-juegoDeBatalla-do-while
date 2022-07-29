/*
 Un héroe y un monstruo comienzan con la misma puntuación de salud.
 Durante el turno de la héroe, se generará un valor aleatorio que se restará de la salud del monstruo. 
 Si la salud del monstruo es mayor que cero, tomará su turno y atacará al héroe. Mientras que la salud del héroe
 y del monstruo sea mayor que cero, el combate se reanudará.
 */
/*
Reglas del juego

-El héroe y el monstruo comenzarán con 10 puntos de salud.
-Todos los ataques serán un valor comprendido entre 1 y 10.
-El héroe atacará primero.
-Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
-Si la salud del monstruo es mayor que 0, puede atacar al héroe.
-Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
-Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
-Imprima el ganador.
*/

int vidaHeroe = 10;
int vidaMonstruo = 10;

Random ataqueBasico = new Random();
int quitarVida = ataqueBasico.Next(1, 11);

do
{
    //ataca el heroe
    Console.WriteLine($"Hero atk, quita {quitarVida} puntos de vida al Monster, le quedan {vidaMonstruo - quitarVida} puntos");
    vidaMonstruo = vidaMonstruo - quitarVida;
    quitarVida = ataqueBasico.Next(1, 11);
    if (vidaMonstruo <= 0) break;
    //ataca el moustro
   Console.WriteLine($"Monster atk, quita {quitarVida} puntos de vida al Hero le quedan {vidaHeroe - quitarVida} puntos");
    vidaHeroe -= quitarVida;
    if (vidaHeroe <= 0) break;
} while (vidaHeroe > 0 || vidaMonstruo > 0);

Console.WriteLine(vidaHeroe > vidaMonstruo ? "Hero win!" : "Monster win!");
